namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DisposableModuleTests() =
    inherit ModularPipelines.UnitTests.Execution.DisposableModuleTests()

    [<Test>]
    member this.SuccessfullyDisposed() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.DisposableModuleTests> "SuccessfullyDisposed" None
