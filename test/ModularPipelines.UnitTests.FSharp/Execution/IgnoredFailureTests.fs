namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type IgnoredFailureTests() =
    inherit ModularPipelines.UnitTests.Execution.IgnoredFailureTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.IgnoredFailureTests> "Has_Not_Thrown_Or_Cancelled_Pipeline" 0 None

