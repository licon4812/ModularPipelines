namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DependsOnModulesWithTagAttributeTests() =
    inherit ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithTagAttributeTests()

    [<Test>]
    member this.ShouldDependOn_ModuleHasTag_ReturnsTrue() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithTagAttributeTests> "ShouldDependOn_ModuleHasTag_ReturnsTrue" None

    [<Test>]
    member this.ShouldDependOn_ModuleLacksTag_ReturnsFalse() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithTagAttributeTests> "ShouldDependOn_ModuleLacksTag_ReturnsFalse" None

    [<Test>]
    member this.ShouldDependOn_ModuleHasNoTags_ReturnsFalse() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithTagAttributeTests> "ShouldDependOn_ModuleHasNoTags_ReturnsFalse" None

    [<Test>]
    member this.ShouldDependOn_CaseInsensitive_ReturnsTrue() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithTagAttributeTests> "ShouldDependOn_CaseInsensitive_ReturnsTrue" None

    [<Test>]
    member this.ShouldDependOn_ModuleHasMultipleTagsIncludingMatch_ReturnsTrue() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithTagAttributeTests> "ShouldDependOn_ModuleHasMultipleTagsIncludingMatch_ReturnsTrue" None

    [<Test>]
    member this.Constructor_WithNullTag_ThrowsArgumentException() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithTagAttributeTests> "Constructor_WithNullTag_ThrowsArgumentException" None

    [<Test>]
    member this.Constructor_WithEmptyTag_ThrowsArgumentException() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithTagAttributeTests> "Constructor_WithEmptyTag_ThrowsArgumentException" None

    [<Test>]
    member this.Constructor_WithWhitespaceTag_ThrowsArgumentException() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithTagAttributeTests> "Constructor_WithWhitespaceTag_ThrowsArgumentException" None

    [<Test>]
    member this.Tag_Property_ReturnsConstructorValue() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithTagAttributeTests> "Tag_Property_ReturnsConstructorValue" None
