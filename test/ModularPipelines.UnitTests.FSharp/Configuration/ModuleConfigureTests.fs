namespace ModularPipelines.UnitTests.FSharp.Configuration

open ModularPipelines.UnitTests.Configuration
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleConfigureTests() =
    inherit ModularPipelines.UnitTests.Configuration.ModuleConfigureTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigureTests> "Module_DefaultConfiguration_ReturnsDefault" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigureTests> "Module_OverriddenConfigure_ReturnsCustomConfig" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigureTests> "Module_Configuration_IsCached" 0 None

