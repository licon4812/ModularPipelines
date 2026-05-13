namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DependsOnModulesWithAttributeAttributeTests() =
    inherit ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithAttributeAttributeTests()

    [<Test>]
    member this.ShouldDependOn_ModuleHasAttribute_ReturnsTrue() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithAttributeAttributeTests> "ShouldDependOn_ModuleHasAttribute_ReturnsTrue" None

    [<Test>]
    member this.ShouldDependOn_ModuleLacksAttribute_ReturnsFalse() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithAttributeAttributeTests> "ShouldDependOn_ModuleLacksAttribute_ReturnsFalse" None

    [<Test>]
    member this.ShouldDependOn_ModuleHasInheritedAttribute_ReturnsTrue() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithAttributeAttributeTests> "ShouldDependOn_ModuleHasInheritedAttribute_ReturnsTrue" None

    [<Test>]
    member this.ShouldDependOn_ModuleHasDifferentAttribute_ReturnsFalse() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithAttributeAttributeTests> "ShouldDependOn_ModuleHasDifferentAttribute_ReturnsFalse" None

    [<Test>]
    member this.ShouldDependOn_ModuleHasMultipleAttributesIncludingMatch_ReturnsTrue() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithAttributeAttributeTests> "ShouldDependOn_ModuleHasMultipleAttributesIncludingMatch_ReturnsTrue" None

    [<Test>]
    member this.ShouldDependOn_CheckingForSerializableAttribute_ReturnsTrue() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithAttributeAttributeTests> "ShouldDependOn_CheckingForSerializableAttribute_ReturnsTrue" None

    [<Test>]
    member this.ShouldDependOn_CheckingForSerializableAttribute_ReturnsFalse() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithAttributeAttributeTests> "ShouldDependOn_CheckingForSerializableAttribute_ReturnsFalse" None
