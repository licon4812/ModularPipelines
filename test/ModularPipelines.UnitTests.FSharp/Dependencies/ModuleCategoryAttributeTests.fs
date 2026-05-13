namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleCategoryAttributeTests() =
    inherit ModularPipelines.UnitTests.Dependencies.ModuleCategoryAttributeTests()

    [<Test>]
    member this.Constructor_WithValidCategory_SetsCategoryProperty() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.ModuleCategoryAttributeTests> "Constructor_WithValidCategory_SetsCategoryProperty" None

    [<Test>]
    member this.Constructor_WithNullCategory_ThrowsArgumentException() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.ModuleCategoryAttributeTests> "Constructor_WithNullCategory_ThrowsArgumentException" None

    [<Test>]
    member this.Constructor_WithEmptyCategory_ThrowsArgumentException() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.ModuleCategoryAttributeTests> "Constructor_WithEmptyCategory_ThrowsArgumentException" None

    [<Test>]
    member this.Attribute_DoesNotAllowMultiple() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.ModuleCategoryAttributeTests> "Attribute_DoesNotAllowMultiple" None

    [<Test>]
    member this.Attribute_IsInheritable() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.ModuleCategoryAttributeTests> "Attribute_IsInheritable" None
