namespace ModularPipelines.UnitTests.FSharp.Logging

open ModularPipelines.UnitTests.Logging
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type PipelineLevelLoggerTests() =
    inherit ModularPipelines.UnitTests.Logging.PipelineLevelLoggerTests()

    [<Test>]
    member this.IsEnabled_DelegatesToUnderlyingLogger() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.PipelineLevelLoggerTests> "IsEnabled_DelegatesToUnderlyingLogger" None

    [<Test>]
    member this.BeginScope_DelegatesToUnderlyingLogger() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.PipelineLevelLoggerTests> "BeginScope_DelegatesToUnderlyingLogger" None
