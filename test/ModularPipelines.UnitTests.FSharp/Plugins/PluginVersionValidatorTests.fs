namespace ModularPipelines.UnitTests.FSharp.Plugins

open ModularPipelines.UnitTests.Plugins
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type PluginVersionValidatorTests() =
    inherit ModularPipelines.UnitTests.Plugins.PluginVersionValidatorTests()

    [<Test>]
    member this.Validate_WithoutAttribute_DoesNotThrow() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.PluginVersionValidatorTests> "Validate_WithoutAttribute_DoesNotThrow" None

    [<Test>]
    member this.IsCompatible_WithoutAttribute_ReturnsTrue() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.PluginVersionValidatorTests> "IsCompatible_WithoutAttribute_ReturnsTrue" None

    [<Test>]
    member this.IsCompatible_WithNullVersion_ReturnsTrueForNoAttribute() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.PluginVersionValidatorTests> "IsCompatible_WithNullVersion_ReturnsTrueForNoAttribute" None
