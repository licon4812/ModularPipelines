namespace ModularPipelines.UnitTests.FSharp.Plugins

open ModularPipelines.UnitTests.Plugins
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type PluginVersionValidatorTests() =
    inherit ModularPipelines.UnitTests.Plugins.PluginVersionValidatorTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.PluginVersionValidatorTests> "Validate_WithoutAttribute_DoesNotThrow" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.PluginVersionValidatorTests> "IsCompatible_WithoutAttribute_ReturnsTrue" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.PluginVersionValidatorTests> "IsCompatible_WithNullVersion_ReturnsTrueForNoAttribute" 0 None

