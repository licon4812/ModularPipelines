namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open ModularPipelines.UnitTests.Attributes
open TUnit.Core

type BashTests() =
    inherit ModularPipelines.UnitTests.Helpers.BashTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.BashTests> "Has_Not_Errored" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.BashTests> "Standard_Output_Equals_Foo_Bar" 0 None

    [<Test>]
    [<LinuxOnlyTest>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.BashTests> "Standard_Output_From_Script_Equals_Foo_Bar" 0 None

