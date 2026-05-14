namespace ModularPipelines.UnitTests.FSharp.Execution

open System.Collections.Concurrent
open System.Threading
open System.Threading.Tasks
open ModularPipelines.Attributes
open ModularPipelines.Context
open ModularPipelines.Enums
open ModularPipelines.Modules
open ModularPipelines.TestHelpers
open TUnit.Assertions
open TUnit.Assertions.FSharp.Operations
open TUnit.Core

let private cpuModulesExecuting = ConcurrentBag<string>()
let private cpuViolations = ConcurrentBag<string>()
let mutable private maxCpuConcurrency = 0

[<ExecutionHint(ExecutionType.CpuIntensive)>]
type private CpuIntensiveModule1() =
    inherit Module<string>()

    override _.ExecuteAsync(_: IModuleContext, cancellationToken: CancellationToken) =
        task {
            let moduleName = _.GetType().Name
            cpuModulesExecuting.Add(moduleName)

            let currentCount = cpuModulesExecuting.Count
            if currentCount > maxCpuConcurrency then
                Interlocked.Exchange(&maxCpuConcurrency, currentCount) |> ignore

            do! Task.Delay(50, cancellationToken)

            if cpuModulesExecuting.Count > 2 then
                cpuViolations.Add($"{moduleName}: {cpuModulesExecuting.Count} concurrent CPU-intensive modules")

            let mutable ignored = Unchecked.defaultof<string>
            cpuModulesExecuting.TryTake(&ignored) |> ignore
            return moduleName
        }

[<ExecutionHint(ExecutionType.CpuIntensive)>]
type private CpuIntensiveModule2() =
    inherit Module<string>()

    override _.ExecuteAsync(_: IModuleContext, cancellationToken: CancellationToken) =
        task {
            let moduleName = _.GetType().Name
            cpuModulesExecuting.Add(moduleName)

            let currentCount = cpuModulesExecuting.Count
            if currentCount > maxCpuConcurrency then
                Interlocked.Exchange(&maxCpuConcurrency, currentCount) |> ignore

            do! Task.Delay(50, cancellationToken)

            let mutable ignored = Unchecked.defaultof<string>
            cpuModulesExecuting.TryTake(&ignored) |> ignore
            return moduleName
        }

[<ExecutionHint(ExecutionType.CpuIntensive)>]
type private CpuIntensiveModule3() =
    inherit Module<string>()

    override _.ExecuteAsync(_: IModuleContext, cancellationToken: CancellationToken) =
        task {
            let moduleName = _.GetType().Name
            cpuModulesExecuting.Add(moduleName)

            let currentCount = cpuModulesExecuting.Count
            if currentCount > maxCpuConcurrency then
                Interlocked.Exchange(&maxCpuConcurrency, currentCount) |> ignore

            do! Task.Delay(50, cancellationToken)

            let mutable ignored = Unchecked.defaultof<string>
            cpuModulesExecuting.TryTake(&ignored) |> ignore
            return moduleName
        }

[<ExecutionHint(ExecutionType.IoIntensive)>]
type private IoIntensiveModule() =
    inherit Module<string>()
    override _.ExecuteAsync(_: IModuleContext, cancellationToken: CancellationToken) =
        task {
            do! Task.Delay(10, cancellationToken)
            return "IoIntensive"
        }

[<ExecutionHint(ExecutionType.Default)>]
type private DefaultExecutionTypeModule() =
    inherit Module<string>()
    override _.ExecuteAsync(_: IModuleContext, _: CancellationToken) = Task.FromResult("Default")

type private NoHintModule() =
    inherit Module<string>()
    override _.ExecuteAsync(_: IModuleContext, _: CancellationToken) = Task.FromResult("NoHint")

[<NotInParallel(nameof ExecutionHintTests)>]
type ExecutionHintTests() =
    inherit TestBase()

    [<Before(HookType.Test)>]
    member _.ClearState() =
        let mutable executingItem = Unchecked.defaultof<string>
        while cpuModulesExecuting.TryTake(&executingItem) do ()

        let mutable violationItem = Unchecked.defaultof<string>
        while cpuViolations.TryTake(&violationItem) do ()

        maxCpuConcurrency <- 0

    [<Test>]
    member _.ExecutionHintAttribute_CanBeAppliedToModule() = async {
        let! result =
            TestPipelineHostBuilder.Create().AddModule<CpuIntensiveModule1>().ExecutePipelineAsync()
            |> Async.AwaitTask

        do! check(Assert.That(result.Status).IsEqualTo(Status.Successful))
    }

    [<Test>]
    member _.ModulesWithoutExecutionHint_UseDefaultType() = async {
        let! result =
            TestPipelineHostBuilder.Create().AddModule<NoHintModule>().ExecutePipelineAsync()
            |> Async.AwaitTask

        do! check(Assert.That(result.Status).IsEqualTo(Status.Successful))
    }

    [<Test>]
    member _.AllExecutionTypes_ExecuteSuccessfully() = async {
        let! result =
            TestPipelineHostBuilder.Create()
                .AddModule<CpuIntensiveModule1>()
                .AddModule<IoIntensiveModule>()
                .AddModule<DefaultExecutionTypeModule>()
                .AddModule<NoHintModule>()
                .ExecutePipelineAsync()
            |> Async.AwaitTask

        do! check(Assert.That(result.Status).IsEqualTo(Status.Successful))
    }

    [<Test>]
    member _.CpuIntensiveModules_AreThrottled() = async {
        let! result =
            TestPipelineHostBuilder.Create()
                .AddModule<CpuIntensiveModule1>()
                .AddModule<CpuIntensiveModule2>()
                .AddModule<CpuIntensiveModule3>()
                .ConfigurePipelineOptions(fun _ options -> options.Concurrency.MaxCpuIntensiveModules <- 2)
                .ExecutePipelineAsync()
            |> Async.AwaitTask

        do! check(Assert.That(result.Status).IsEqualTo(Status.Successful))
        do! check(Assert.That(maxCpuConcurrency).IsLessThanOrEqualTo(2))
    }
