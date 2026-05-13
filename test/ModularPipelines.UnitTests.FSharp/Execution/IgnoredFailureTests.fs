namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type IgnoredFailureTests() =
    inherit ModularPipelines.UnitTests.Execution.IgnoredFailureTests()

    [<Test>]
    member this.Has_Not_Thrown_Or_Cancelled_Pipeline() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.IgnoredFailureTests> "Has_Not_Thrown_Or_Cancelled_Pipeline" None
