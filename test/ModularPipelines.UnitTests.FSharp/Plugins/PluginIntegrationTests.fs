namespace ModularPipelines.UnitTests.FSharp.Plugins

open ModularPipelines.UnitTests.Plugins
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<TUnit.Core.NotInParallel(nameof(PluginIntegrationTests))>]
type PluginIntegrationTests() =
    inherit ModularPipelines.UnitTests.Plugins.PluginIntegrationTests()

    [<Test>]
    member this.ApplyPluginServices_CallsConfigureServicesOnAllPlugins() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.PluginIntegrationTests> "ApplyPluginServices_CallsConfigureServicesOnAllPlugins" None

    [<Test>]
    member this.ApplyPluginServices_ThrowsPluginInitializationException_WhenPluginFails() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.PluginIntegrationTests> "ApplyPluginServices_ThrowsPluginInitializationException_WhenPluginFails" None

    [<Test>]
    member this.ApplyPluginConfiguration_CallsConfigurePipelineOnAllPlugins() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.PluginIntegrationTests> "ApplyPluginConfiguration_CallsConfigurePipelineOnAllPlugins" None

    [<Test>]
    member this.ApplyPluginConfiguration_ThrowsPluginInitializationException_WhenPluginFails() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.PluginIntegrationTests> "ApplyPluginConfiguration_ThrowsPluginInitializationException_WhenPluginFails" None

    [<Test>]
    member this.ApplyPluginServices_AppliesInPriorityOrder() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.PluginIntegrationTests> "ApplyPluginServices_AppliesInPriorityOrder" None

    [<Test>]
    member this.Plugins_CanRegisterServices() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.PluginIntegrationTests> "Plugins_CanRegisterServices" None
