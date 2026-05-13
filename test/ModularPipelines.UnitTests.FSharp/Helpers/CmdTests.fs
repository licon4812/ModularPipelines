namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open ModularPipelines.UnitTests.Attributes
open TUnit.Core

[<WindowsOnlyTest>]
type CmdTests() =
    inherit ModularPipelines.UnitTests.Helpers.CmdTests()

    [<Test>]
    member this.Has_Not_Errored() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.CmdTests> "Has_Not_Errored" None

    [<Test>]
    member this.Standard_Output_Equals_Foo_Bar() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.CmdTests> "Standard_Output_Equals_Foo_Bar" None
