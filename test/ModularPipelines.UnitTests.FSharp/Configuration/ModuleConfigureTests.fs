namespace ModularPipelines.UnitTests.FSharp.Configuration

open ModularPipelines.UnitTests.Configuration
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleConfigureTests() =
    inherit ModularPipelines.UnitTests.Configuration.ModuleConfigureTests()

    [<Test>]
    member this.Module_DefaultConfiguration_ReturnsDefault() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigureTests> "Module_DefaultConfiguration_ReturnsDefault" None

    [<Test>]
    member this.Module_OverriddenConfigure_ReturnsCustomConfig() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigureTests> "Module_OverriddenConfigure_ReturnsCustomConfig" None

    [<Test>]
    member this.Module_Configuration_IsCached() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigureTests> "Module_Configuration_IsCached" None
