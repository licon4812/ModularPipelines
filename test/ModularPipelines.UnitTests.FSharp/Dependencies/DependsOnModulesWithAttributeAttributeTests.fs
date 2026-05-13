namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DependsOnModulesWithAttributeAttributeTests() =
    inherit ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithAttributeAttributeTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithAttributeAttributeTests> "ShouldDependOn_ModuleHasAttribute_ReturnsTrue" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithAttributeAttributeTests> "ShouldDependOn_ModuleLacksAttribute_ReturnsFalse" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithAttributeAttributeTests> "ShouldDependOn_ModuleHasInheritedAttribute_ReturnsTrue" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithAttributeAttributeTests> "ShouldDependOn_ModuleHasDifferentAttribute_ReturnsFalse" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithAttributeAttributeTests> "ShouldDependOn_ModuleHasMultipleAttributesIncludingMatch_ReturnsTrue" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithAttributeAttributeTests> "ShouldDependOn_CheckingForSerializableAttribute_ReturnsTrue" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithAttributeAttributeTests> "ShouldDependOn_CheckingForSerializableAttribute_ReturnsFalse" 0 None

