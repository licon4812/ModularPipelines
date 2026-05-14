namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.Context
open ModularPipelines.Enums
open ModularPipelines.Modules
open ModularPipelines.Options
open ModularPipelines.TestHelpers
open TUnit.Assertions
open TUnit.Assertions.FSharp.Operations
open TUnit.Core

[<NotInParallel(nameof ConcurrencyOptionsTests)>]
type private SimpleModule() =
    inherit Module<string>()
    override _.ExecuteAsync(_: IModuleContext, _: System.Threading.CancellationToken) = System.Threading.Tasks.Task.FromResult("Done")

[<NotInParallel(nameof ConcurrencyOptionsTests)>]
type private SimpleModule2() =
    inherit Module<string>()
    override _.ExecuteAsync(_: IModuleContext, _: System.Threading.CancellationToken) = System.Threading.Tasks.Task.FromResult("Done")

[<NotInParallel(nameof ConcurrencyOptionsTests)>]
type ConcurrencyOptionsTests() =
    inherit TestBase()

    [<Test>]
    member _.ConcurrencyOptions_HasCorrectDefaultValues() = async {
        let options = ConcurrencyOptions()
        let expectedMaxParallelism = System.Environment.ProcessorCount * 4

        do! check(Assert.That(options.MaxParallelism).IsEqualTo(expectedMaxParallelism))
        do! check(Assert.That(options.MaxCpuIntensiveModules).IsEqualTo(System.Environment.ProcessorCount))
        do! check(Assert.That(options.MaxIoIntensiveModules).IsNull())
    }

    [<Test>]
    member _.Pipeline_RespectsMaxParallelismSetting() = async {
        let! result =
            TestPipelineHostBuilder.Create()
                .AddModule<SimpleModule>()
                .AddModule<SimpleModule2>()
                .ConfigurePipelineOptions(fun _ options -> options.Concurrency.MaxParallelism <- 2)
                .ExecutePipelineAsync()
            |> Async.AwaitTask

        do! check(Assert.That(result.Status).IsEqualTo(Status.Successful))
    }

    [<Test>]
    member _.Pipeline_RespectsMaxCpuIntensiveModulesSetting() = async {
        let! result =
            TestPipelineHostBuilder.Create()
                .AddModule<SimpleModule>()
                .ConfigurePipelineOptions(fun _ options -> options.Concurrency.MaxCpuIntensiveModules <- 1)
                .ExecutePipelineAsync()
            |> Async.AwaitTask

        do! check(Assert.That(result.Status).IsEqualTo(Status.Successful))
    }

    [<Test>]
    member _.Pipeline_RespectsMaxIoIntensiveModulesSetting() = async {
        let! result =
            TestPipelineHostBuilder.Create()
                .AddModule<SimpleModule>()
                .ConfigurePipelineOptions(fun _ options -> options.Concurrency.MaxIoIntensiveModules <- System.Nullable 10)
                .ExecutePipelineAsync()
            |> Async.AwaitTask

        do! check(Assert.That(result.Status).IsEqualTo(Status.Successful))
    }

    [<Test>]
    member _.PipelineOptions_HasConcurrencyProperty() = async {
        let options = PipelineOptions()

        do! check(Assert.That(options.Concurrency).IsNotNull())
        do! check(Assert.That(options.Concurrency).IsTypeOf<ConcurrencyOptions>())
    }
