namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type CommandTests() =
    inherit ModularPipelines.UnitTests.Helpers.CommandTests()

    [<Test>]
    member this.Has_Not_Errored() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.CommandTests> "Has_Not_Errored" None

    [<Test>]
    member this.Standard_Output_Equals_Foo_Bar() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.CommandTests> "Standard_Output_Equals_Foo_Bar" None

    [<Test>]
    member this.Standard_Output_Equals_Foo_Bar_With_Timeout() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.CommandTests> "Standard_Output_Equals_Foo_Bar_With_Timeout" None
