namespace ModularPipelines.UnitTests.FSharp.Plugins

open ModularPipelines.UnitTests.Plugins
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<TUnit.Core.NotInParallel(nameof(PluginIntegrationTests))>]
type PluginIntegrationTests() =
    inherit ModularPipelines.UnitTests.Plugins.PluginIntegrationTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.PluginIntegrationTests> "ApplyPluginServices_CallsConfigureServicesOnAllPlugins" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.PluginIntegrationTests> "ApplyPluginServices_ThrowsPluginInitializationException_WhenPluginFails" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.PluginIntegrationTests> "ApplyPluginConfiguration_CallsConfigurePipelineOnAllPlugins" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.PluginIntegrationTests> "ApplyPluginConfiguration_ThrowsPluginInitializationException_WhenPluginFails" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.PluginIntegrationTests> "ApplyPluginServices_AppliesInPriorityOrder" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.PluginIntegrationTests> "Plugins_CanRegisterServices" 0 None

