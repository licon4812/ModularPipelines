namespace ModularPipelines.UnitTests.FSharp.Logging

open ModularPipelines.UnitTests.Logging
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type PipelineLevelLoggerTests() =
    inherit ModularPipelines.UnitTests.Logging.PipelineLevelLoggerTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.PipelineLevelLoggerTests> "IsEnabled_DelegatesToUnderlyingLogger" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.PipelineLevelLoggerTests> "BeginScope_DelegatesToUnderlyingLogger" 0 None

