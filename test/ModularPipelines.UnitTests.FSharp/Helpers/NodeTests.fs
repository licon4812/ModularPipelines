namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type NodeTests() =
    inherit ModularPipelines.UnitTests.Helpers.NodeTests()

    [<Test>]
    member this.Has_Not_Errored() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.NodeTests> "Has_Not_Errored" None

    [<Test>]
    member this.Standard_Output_Is_Version_Number() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.NodeTests> "Standard_Output_Is_Version_Number" None
