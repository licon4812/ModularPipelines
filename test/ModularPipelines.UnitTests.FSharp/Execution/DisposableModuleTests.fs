namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DisposableModuleTests() =
    inherit ModularPipelines.UnitTests.Execution.DisposableModuleTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.DisposableModuleTests> "SuccessfullyDisposed" 0 None

