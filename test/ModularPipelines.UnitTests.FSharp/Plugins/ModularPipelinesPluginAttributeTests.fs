namespace ModularPipelines.UnitTests.FSharp.Plugins

open ModularPipelines.UnitTests.Plugins
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModularPipelinesPluginAttributeTests() =
    inherit ModularPipelines.UnitTests.Plugins.ModularPipelinesPluginAttributeTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.ModularPipelinesPluginAttributeTests> "Constructor_SetsCompatibleMajorVersion" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.ModularPipelinesPluginAttributeTests> "Constructor_AcceptsZero" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.ModularPipelinesPluginAttributeTests> "Constructor_ThrowsForNegativeVersion" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.ModularPipelinesPluginAttributeTests> "Attribute_HasCorrectUsage" 0 None

