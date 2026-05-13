namespace ModularPipelines.UnitTests.FSharp.Plugins

open ModularPipelines.UnitTests.Plugins
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<TUnit.Core.NotInParallel(nameof(PluginRegistryTests))>]
type PluginRegistryTests() =
    inherit ModularPipelines.UnitTests.Plugins.PluginRegistryTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.PluginRegistryTests> "Register_AddsPluginToRegistry" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.PluginRegistryTests> "Register_DuplicateName_ThrowsInvalidOperationException" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.PluginRegistryTests> "Register_NullPlugin_ThrowsArgumentNullException" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.PluginRegistryTests> "Plugins_ReturnsOrderedByPriority" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.PluginRegistryTests> "Clear_RemovesAllPlugins" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.PluginRegistryTests> "IsolatedRegistry_RestoresOriginalPlugins" 0 None

