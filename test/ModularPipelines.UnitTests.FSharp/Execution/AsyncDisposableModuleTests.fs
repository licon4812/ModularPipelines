namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type AsyncDisposableModuleTests() =
    inherit ModularPipelines.UnitTests.Execution.AsyncDisposableModuleTests()

    [<Test>]
    member this.SuccessfullyDisposed() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.AsyncDisposableModuleTests> "SuccessfullyDisposed" None
