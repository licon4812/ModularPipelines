namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type SpectreMarkupEscaperTests() =
    inherit ModularPipelines.UnitTests.Helpers.SpectreMarkupEscaperTests()

    [<Test>]
    member this.Escape_WithNullInput_ReturnsEmptyString() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.SpectreMarkupEscaperTests> "Escape_WithNullInput_ReturnsEmptyString" None

    [<Test>]
    member this.Escape_WithEmptyString_ReturnsEmptyString() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.SpectreMarkupEscaperTests> "Escape_WithEmptyString_ReturnsEmptyString" None

    [<Test>]
    member this.Escape_WithNoSpecialCharacters_ReturnsSameString() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.SpectreMarkupEscaperTests> "Escape_WithNoSpecialCharacters_ReturnsSameString" None

    [<Test>]
    member this.Escape_WithOpenBracket_EscapesBracket() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.SpectreMarkupEscaperTests> "Escape_WithOpenBracket_EscapesBracket" None

    [<Test>]
    member this.Escape_WithCloseBracket_EscapesBracket() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.SpectreMarkupEscaperTests> "Escape_WithCloseBracket_EscapesBracket" None

    [<Test>]
    member this.Escape_WithMultipleBrackets_EscapesAll() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.SpectreMarkupEscaperTests> "Escape_WithMultipleBrackets_EscapesAll" None

    [<Test>]
    member this.Escape_WithSpectreMarkupLikeSyntax_EscapesProperly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.SpectreMarkupEscaperTests> "Escape_WithSpectreMarkupLikeSyntax_EscapesProperly" None

    [<Test>]
    member this.Escape_WithGenericTypeSyntax_EscapesProperly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.SpectreMarkupEscaperTests> "Escape_WithGenericTypeSyntax_EscapesProperly" None
