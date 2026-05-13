namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type HasherTests() =
    inherit ModularPipelines.UnitTests.Helpers.HasherTests()

    [<Test>]
    [<DisplayName("Hash algorithm '$algorithm' produces correct output")>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.HasherTests> "Hash_Algorithm_Produces_Expected_Output" 0 (Some 0)

    [<Test>]
    [<DisplayName("Hash algorithm '$algorithm' produces correct output")>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.HasherTests> "Hash_Algorithm_Produces_Expected_Output" 0 (Some 1)

    [<Test>]
    [<DisplayName("Hash algorithm '$algorithm' produces correct output")>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.HasherTests> "Hash_Algorithm_Produces_Expected_Output" 0 (Some 2)

    [<Test>]
    [<DisplayName("Hash algorithm '$algorithm' produces correct output")>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.HasherTests> "Hash_Algorithm_Produces_Expected_Output" 0 (Some 3)

    [<Test>]
    [<DisplayName("Hash algorithm '$algorithm' produces correct output")>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.HasherTests> "Hash_Algorithm_Produces_Expected_Output" 0 (Some 4)

