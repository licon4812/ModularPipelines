namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DependsOnModulesWithTagAttributeTests() =
    inherit ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithTagAttributeTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithTagAttributeTests> "ShouldDependOn_ModuleHasTag_ReturnsTrue" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithTagAttributeTests> "ShouldDependOn_ModuleLacksTag_ReturnsFalse" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithTagAttributeTests> "ShouldDependOn_ModuleHasNoTags_ReturnsFalse" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithTagAttributeTests> "ShouldDependOn_CaseInsensitive_ReturnsTrue" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithTagAttributeTests> "ShouldDependOn_ModuleHasMultipleTagsIncludingMatch_ReturnsTrue" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithTagAttributeTests> "Constructor_WithNullTag_ThrowsArgumentException" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithTagAttributeTests> "Constructor_WithEmptyTag_ThrowsArgumentException" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithTagAttributeTests> "Constructor_WithWhitespaceTag_ThrowsArgumentException" 0 None

    [<Test>]
    member this.Test_9() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnModulesWithTagAttributeTests> "Tag_Property_ReturnsConstructorValue" 0 None

