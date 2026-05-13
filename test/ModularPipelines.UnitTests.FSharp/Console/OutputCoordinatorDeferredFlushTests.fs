namespace ModularPipelines.UnitTests.FSharp.Console

open System.Threading.Tasks
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Logging
open ModularPipelines.Context
open ModularPipelines.Enums
open ModularPipelines.Extensions
open ModularPipelines.Modules
open ModularPipelines.Options
open ModularPipelines.TestHelpers
open TUnit.Assertions
open TUnit.Assertions.Extensions
open TUnit.Assertions.FSharp.Operations
open TUnit.Core

type private Module1() =
    inherit Module<bool>()

    override _.ExecuteAsync(context: IModuleContext, cancellationToken) =
        task {
            context.Logger.LogInformation("Module1 output")
            do! Task.Delay(50, cancellationToken)
            return true
        }

type private Module2() =
    inherit Module<bool>()

    override _.ExecuteAsync(context: IModuleContext, _) =
        task {
            context.Logger.LogInformation("Module2 output")
            do! Task.Yield()
            return true
        }

type OutputCoordinatorDeferredFlushTests() =
    [<Test>]
    member _.Pipeline_Completes_When_Progress_Disabled() = async {
        let! host =
            TestPipelineHostBuilder.Create()
                .ConfigureServices(fun _ services ->
                    services.Configure<PipelineOptions>(fun options ->
                        options.ShowProgressInConsole <- false))
                .AddModule<Module1>()
                .BuildHostAsync()
            |> Async.AwaitTask

        try
            let! result = host.ExecutePipelineAsync() |> Async.AwaitTask
            do! check(Assert.That(result.Status).IsEqualTo(Status.Successful))
        finally
            do! host.DisposeAsync().AsTask() |> Async.AwaitTask
    }

    [<Test>]
    member _.Pipeline_With_Multiple_Modules_Completes_Successfully() = async {
        let! host =
            TestPipelineHostBuilder.Create()
                .ConfigureServices(fun _ services ->
                    services.Configure<PipelineOptions>(fun options ->
                        options.ShowProgressInConsole <- false))
                .AddModule<Module1>()
                .AddModule<Module2>()
                .BuildHostAsync()
            |> Async.AwaitTask

        try
            let! result = host.ExecutePipelineAsync() |> Async.AwaitTask
            do! check(Assert.That(result.Status).IsEqualTo(Status.Successful))
        finally
            do! host.DisposeAsync().AsTask() |> Async.AwaitTask
    }
