namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type PowershellTests() =
    inherit ModularPipelines.UnitTests.Helpers.PowershellTests()

    [<Test>]
    member this.Has_Not_Errored() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.PowershellTests> "Has_Not_Errored" None

    [<Test>]
    member this.Standard_Output_Equals_Foo_Bar() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.PowershellTests> "Standard_Output_Equals_Foo_Bar" None
