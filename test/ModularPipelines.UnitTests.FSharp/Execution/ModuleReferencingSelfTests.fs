namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleReferencingSelfTests() =
    inherit ModularPipelines.UnitTests.Execution.ModuleReferencingSelfTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ModuleReferencingSelfTests> "Throws_Exception" 0 None

