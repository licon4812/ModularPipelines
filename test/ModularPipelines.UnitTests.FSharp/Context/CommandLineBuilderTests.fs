namespace ModularPipelines.UnitTests.FSharp.Context

open ModularPipelines.UnitTests.Context
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type CommandLineBuilderTests() =
    inherit ModularPipelines.UnitTests.Context.CommandLineBuilderTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.CommandLineBuilderTests> "Build_FromGenericOptions_ReturnsCorrectCommandLine" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.CommandLineBuilderTests> "Build_FromGenericOptions_WithRunSettings_AddsDoubleDash" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.CommandLineBuilderTests> "Build_FromAttributeBasedOptions_ResolvesToolAndSubcommands" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.CommandLineBuilderTests> "Build_WithPositionalArguments_PlacesCorrectly" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.CommandLineBuilderTests> "Build_ReturnsImmutableCommandLine" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.CommandLineBuilderTests> "Build_ToString_FormatsCorrectly" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.CommandLineBuilderTests> "Build_SkipsDuplicateToolInArguments" 0 None

