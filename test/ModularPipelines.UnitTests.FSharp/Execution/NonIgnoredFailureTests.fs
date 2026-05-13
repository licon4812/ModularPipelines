namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type NonIgnoredFailureTests() =
    inherit ModularPipelines.UnitTests.Execution.NonIgnoredFailureTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.NonIgnoredFailureTests> "Has_Thrown_And_Cancelled_Pipeline" 0 None

