namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type AsyncDisposableModuleTests() =
    inherit ModularPipelines.UnitTests.Execution.AsyncDisposableModuleTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.AsyncDisposableModuleTests> "SuccessfullyDisposed" 0 None

