namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type HasherTests() =
    inherit ModularPipelines.UnitTests.Helpers.HasherTests()

    [<Test>]
    [<DisplayName("Hash algorithm '$algorithm' produces correct output")>]
    member this.Hash_Algorithm_Produces_Expected_Output_Arguments1() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.HasherTests> "Hash_Algorithm_Produces_Expected_Output" (Some 0)

    [<Test>]
    [<DisplayName("Hash algorithm '$algorithm' produces correct output")>]
    member this.Hash_Algorithm_Produces_Expected_Output_Arguments2() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.HasherTests> "Hash_Algorithm_Produces_Expected_Output" (Some 1)

    [<Test>]
    [<DisplayName("Hash algorithm '$algorithm' produces correct output")>]
    member this.Hash_Algorithm_Produces_Expected_Output_Arguments3() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.HasherTests> "Hash_Algorithm_Produces_Expected_Output" (Some 2)

    [<Test>]
    [<DisplayName("Hash algorithm '$algorithm' produces correct output")>]
    member this.Hash_Algorithm_Produces_Expected_Output_Arguments4() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.HasherTests> "Hash_Algorithm_Produces_Expected_Output" (Some 3)

    [<Test>]
    [<DisplayName("Hash algorithm '$algorithm' produces correct output")>]
    member this.Hash_Algorithm_Produces_Expected_Output_Arguments5() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.HasherTests> "Hash_Algorithm_Produces_Expected_Output" (Some 4)
