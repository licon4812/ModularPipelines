namespace ModularPipelines.UnitTests.FSharp.Context

open ModularPipelines.UnitTests.Context
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type CommandLineBuilderTests() =
    inherit ModularPipelines.UnitTests.Context.CommandLineBuilderTests()

    [<Test>]
    member this.Build_FromGenericOptions_ReturnsCorrectCommandLine() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.CommandLineBuilderTests> "Build_FromGenericOptions_ReturnsCorrectCommandLine" None

    [<Test>]
    member this.Build_FromGenericOptions_WithRunSettings_AddsDoubleDash() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.CommandLineBuilderTests> "Build_FromGenericOptions_WithRunSettings_AddsDoubleDash" None

    [<Test>]
    member this.Build_FromAttributeBasedOptions_ResolvesToolAndSubcommands() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.CommandLineBuilderTests> "Build_FromAttributeBasedOptions_ResolvesToolAndSubcommands" None

    [<Test>]
    member this.Build_WithPositionalArguments_PlacesCorrectly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.CommandLineBuilderTests> "Build_WithPositionalArguments_PlacesCorrectly" None

    [<Test>]
    member this.Build_ReturnsImmutableCommandLine() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.CommandLineBuilderTests> "Build_ReturnsImmutableCommandLine" None

    [<Test>]
    member this.Build_ToString_FormatsCorrectly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.CommandLineBuilderTests> "Build_ToString_FormatsCorrectly" None

    [<Test>]
    member this.Build_SkipsDuplicateToolInArguments() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.CommandLineBuilderTests> "Build_SkipsDuplicateToolInArguments" None
