namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DependsOnModulesInCategoryAttributeTests() =
    inherit ModularPipelines.UnitTests.Dependencies.DependsOnModulesInCategoryAttributeTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesInCategoryAttributeTests> "ShouldDependOn_ModuleInCategory_ReturnsTrue" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesInCategoryAttributeTests> "ShouldDependOn_ModuleInDifferentCategory_ReturnsFalse" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesInCategoryAttributeTests> "ShouldDependOn_CaseInsensitive_ReturnsTrue" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesInCategoryAttributeTests> "ShouldDependOn_ModuleHasNoCategory_ReturnsFalse" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesInCategoryAttributeTests> "ShouldDependOn_CategoryMatchesExactly_ReturnsTrue" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesInCategoryAttributeTests> "Constructor_WithNullCategory_ThrowsArgumentException" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesInCategoryAttributeTests> "Constructor_WithEmptyCategory_ThrowsArgumentException" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesInCategoryAttributeTests> "Constructor_WithWhitespaceCategory_ThrowsArgumentException" 0 None

    [<Test>]
    member this.Test_9() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesInCategoryAttributeTests> "Category_Property_ReturnsConstructorValue" 0 None

