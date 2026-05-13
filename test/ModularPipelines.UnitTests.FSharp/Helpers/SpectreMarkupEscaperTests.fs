namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type SpectreMarkupEscaperTests() =
    inherit ModularPipelines.UnitTests.Helpers.SpectreMarkupEscaperTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.SpectreMarkupEscaperTests> "Escape_WithNullInput_ReturnsEmptyString" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.SpectreMarkupEscaperTests> "Escape_WithEmptyString_ReturnsEmptyString" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.SpectreMarkupEscaperTests> "Escape_WithNoSpecialCharacters_ReturnsSameString" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.SpectreMarkupEscaperTests> "Escape_WithOpenBracket_EscapesBracket" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.SpectreMarkupEscaperTests> "Escape_WithCloseBracket_EscapesBracket" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.SpectreMarkupEscaperTests> "Escape_WithMultipleBrackets_EscapesAll" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.SpectreMarkupEscaperTests> "Escape_WithSpectreMarkupLikeSyntax_EscapesProperly" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.SpectreMarkupEscaperTests> "Escape_WithGenericTypeSyntax_EscapesProperly" 0 None

