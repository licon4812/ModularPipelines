namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<TUnit.Core.NotInParallel(nameof(FlexibleDependencyIntegrationTests))>]
type FlexibleDependencyIntegrationTests() =
    inherit ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "DependsOnModulesWithTag_WaitsForTaggedModules" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "DependsOnModulesWithTag_NoMatchingModules_StillSucceeds" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "DependsOnModulesWithTag_MultipleTagsOnModule_MatchesCorrectly" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "DependsOnModulesInCategory_WaitsForCategorizedModules" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "DependsOnModulesInCategory_NoMatchingModules_StillSucceeds" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "DependsOnModulesWithAttribute_WaitsForAttributedModules" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "DependsOnModulesWithAttribute_InheritedAttribute_IsRecognized" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "DependsOnModulesWithAttribute_NoMatchingModules_StillSucceeds" 0 None

    [<Test>]
    member this.Test_9() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "ModuleWithOverrideTags_IsRecognizedByTagDependency" 0 None

    [<Test>]
    member this.Test_10() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "ModuleWithOverrideCategory_IsRecognizedByCategoryDependency" 0 None

    [<Test>]
    member this.Test_11() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "ModuleWithRegistrationTags_IsRecognizedByTagDependency" 0 None

    [<Test>]
    member this.Test_12() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "ModuleWithRegistrationCategory_IsRecognizedByCategoryDependency" 0 None

    [<Test>]
    member this.Test_13() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "ModuleWithBothAttributeAndRegistrationTags_MergesTags" 0 None

    [<Test>]
    member this.Test_14() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "CombinedDependencies_ModuleWithMultipleFlexibleDependencies" 0 None

    [<Test>]
    member this.Test_15() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "ChainedFlexibleDependencies_ExecuteInCorrectOrder" 0 None

