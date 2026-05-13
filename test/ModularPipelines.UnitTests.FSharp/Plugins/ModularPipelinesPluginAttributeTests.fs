namespace ModularPipelines.UnitTests.FSharp.Plugins

open ModularPipelines.UnitTests.Plugins
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModularPipelinesPluginAttributeTests() =
    inherit ModularPipelines.UnitTests.Plugins.ModularPipelinesPluginAttributeTests()

    [<Test>]
    member this.Constructor_SetsCompatibleMajorVersion() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.ModularPipelinesPluginAttributeTests> "Constructor_SetsCompatibleMajorVersion" None

    [<Test>]
    member this.Constructor_AcceptsZero() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.ModularPipelinesPluginAttributeTests> "Constructor_AcceptsZero" None

    [<Test>]
    member this.Constructor_ThrowsForNegativeVersion() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.ModularPipelinesPluginAttributeTests> "Constructor_ThrowsForNegativeVersion" None

    [<Test>]
    member this.Attribute_HasCorrectUsage() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.ModularPipelinesPluginAttributeTests> "Attribute_HasCorrectUsage" None
