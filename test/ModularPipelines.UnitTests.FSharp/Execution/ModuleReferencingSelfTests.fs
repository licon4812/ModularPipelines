namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleReferencingSelfTests() =
    inherit ModularPipelines.UnitTests.Execution.ModuleReferencingSelfTests()

    [<Test>]
    member this.Throws_Exception() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ModuleReferencingSelfTests> "Throws_Exception" None
