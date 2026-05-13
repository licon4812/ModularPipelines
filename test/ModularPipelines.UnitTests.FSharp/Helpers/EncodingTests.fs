namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type EncodingTests() =
    inherit ModularPipelines.UnitTests.Helpers.EncodingTests()

    [<Test>]
    [<DisplayName("Base64: ToBase64String does not error and produces correct output")>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.EncodingTests> "To_Base64_Works_Correctly" 0 None

    [<Test>]
    [<DisplayName("Base64: FromBase64String does not error and produces correct output")>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.EncodingTests> "From_Base64_Works_Correctly" 0 None

    [<Test>]
    [<DisplayName("Hex: ToHex does not error and produces correct output")>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.EncodingTests> "To_Hex_Works_Correctly" 0 None

    [<Test>]
    [<DisplayName("Hex: FromHex does not error and produces correct output")>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.EncodingTests> "From_Hex_Works_Correctly" 0 None

