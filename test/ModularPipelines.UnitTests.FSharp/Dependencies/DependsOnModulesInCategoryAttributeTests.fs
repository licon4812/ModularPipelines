namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DependsOnModulesInCategoryAttributeTests() =
    inherit ModularPipelines.UnitTests.Dependencies.DependsOnModulesInCategoryAttributeTests()

    [<Test>]
    member this.ShouldDependOn_ModuleInCategory_ReturnsTrue() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesInCategoryAttributeTests> "ShouldDependOn_ModuleInCategory_ReturnsTrue" None

    [<Test>]
    member this.ShouldDependOn_ModuleInDifferentCategory_ReturnsFalse() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesInCategoryAttributeTests> "ShouldDependOn_ModuleInDifferentCategory_ReturnsFalse" None

    [<Test>]
    member this.ShouldDependOn_CaseInsensitive_ReturnsTrue() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesInCategoryAttributeTests> "ShouldDependOn_CaseInsensitive_ReturnsTrue" None

    [<Test>]
    member this.ShouldDependOn_ModuleHasNoCategory_ReturnsFalse() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesInCategoryAttributeTests> "ShouldDependOn_ModuleHasNoCategory_ReturnsFalse" None

    [<Test>]
    member this.ShouldDependOn_CategoryMatchesExactly_ReturnsTrue() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesInCategoryAttributeTests> "ShouldDependOn_CategoryMatchesExactly_ReturnsTrue" None

    [<Test>]
    member this.Constructor_WithNullCategory_ThrowsArgumentException() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesInCategoryAttributeTests> "Constructor_WithNullCategory_ThrowsArgumentException" None

    [<Test>]
    member this.Constructor_WithEmptyCategory_ThrowsArgumentException() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesInCategoryAttributeTests> "Constructor_WithEmptyCategory_ThrowsArgumentException" None

    [<Test>]
    member this.Constructor_WithWhitespaceCategory_ThrowsArgumentException() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesInCategoryAttributeTests> "Constructor_WithWhitespaceCategory_ThrowsArgumentException" None

    [<Test>]
    member this.Category_Property_ReturnsConstructorValue() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesInCategoryAttributeTests> "Category_Property_ReturnsConstructorValue" None
