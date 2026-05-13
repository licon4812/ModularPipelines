namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open ModularPipelines.UnitTests.Attributes
open TUnit.Core

type BashTests() =
    inherit ModularPipelines.UnitTests.Helpers.BashTests()

    [<Test>]
    member this.Has_Not_Errored() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.BashTests> "Has_Not_Errored" None

    [<Test>]
    member this.Standard_Output_Equals_Foo_Bar() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.BashTests> "Standard_Output_Equals_Foo_Bar" None

    [<Test>]
    [<LinuxOnlyTest>]
    member this.Standard_Output_From_Script_Equals_Foo_Bar() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.BashTests> "Standard_Output_From_Script_Equals_Foo_Bar" None
