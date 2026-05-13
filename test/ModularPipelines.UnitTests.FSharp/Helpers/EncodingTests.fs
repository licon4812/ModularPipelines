namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type EncodingTests() =
    inherit ModularPipelines.UnitTests.Helpers.EncodingTests()

    [<Test>]
    [<DisplayName("Base64: ToBase64String does not error and produces correct output")>]
    member this.To_Base64_Works_Correctly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.EncodingTests> "To_Base64_Works_Correctly" None

    [<Test>]
    [<DisplayName("Base64: FromBase64String does not error and produces correct output")>]
    member this.From_Base64_Works_Correctly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.EncodingTests> "From_Base64_Works_Correctly" None

    [<Test>]
    [<DisplayName("Hex: ToHex does not error and produces correct output")>]
    member this.To_Hex_Works_Correctly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.EncodingTests> "To_Hex_Works_Correctly" None

    [<Test>]
    [<DisplayName("Hex: FromHex does not error and produces correct output")>]
    member this.From_Hex_Works_Correctly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.EncodingTests> "From_Hex_Works_Correctly" None
