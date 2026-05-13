namespace ModularPipelines.UnitTests.FSharp.Plugins

open ModularPipelines.UnitTests.Plugins
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<TUnit.Core.NotInParallel(nameof(PluginRegistryTests))>]
type PluginRegistryTests() =
    inherit ModularPipelines.UnitTests.Plugins.PluginRegistryTests()

    [<Test>]
    member this.Register_AddsPluginToRegistry() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.PluginRegistryTests> "Register_AddsPluginToRegistry" None

    [<Test>]
    member this.Register_DuplicateName_ThrowsInvalidOperationException() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.PluginRegistryTests> "Register_DuplicateName_ThrowsInvalidOperationException" None

    [<Test>]
    member this.Register_NullPlugin_ThrowsArgumentNullException() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.PluginRegistryTests> "Register_NullPlugin_ThrowsArgumentNullException" None

    [<Test>]
    member this.Plugins_ReturnsOrderedByPriority() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.PluginRegistryTests> "Plugins_ReturnsOrderedByPriority" None

    [<Test>]
    member this.Clear_RemovesAllPlugins() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.PluginRegistryTests> "Clear_RemovesAllPlugins" None

    [<Test>]
    member this.IsolatedRegistry_RestoresOriginalPlugins() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.PluginRegistryTests> "IsolatedRegistry_RestoresOriginalPlugins" None
