namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<TUnit.Core.NotInParallel(nameof(FlexibleDependencyIntegrationTests))>]
type FlexibleDependencyIntegrationTests() =
    inherit ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests()

    [<Test>]
    member this.DependsOnModulesWithTag_WaitsForTaggedModules() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "DependsOnModulesWithTag_WaitsForTaggedModules" None

    [<Test>]
    member this.DependsOnModulesWithTag_NoMatchingModules_StillSucceeds() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "DependsOnModulesWithTag_NoMatchingModules_StillSucceeds" None

    [<Test>]
    member this.DependsOnModulesWithTag_MultipleTagsOnModule_MatchesCorrectly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "DependsOnModulesWithTag_MultipleTagsOnModule_MatchesCorrectly" None

    [<Test>]
    member this.DependsOnModulesInCategory_WaitsForCategorizedModules() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "DependsOnModulesInCategory_WaitsForCategorizedModules" None

    [<Test>]
    member this.DependsOnModulesInCategory_NoMatchingModules_StillSucceeds() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "DependsOnModulesInCategory_NoMatchingModules_StillSucceeds" None

    [<Test>]
    member this.DependsOnModulesWithAttribute_WaitsForAttributedModules() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "DependsOnModulesWithAttribute_WaitsForAttributedModules" None

    [<Test>]
    member this.DependsOnModulesWithAttribute_InheritedAttribute_IsRecognized() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "DependsOnModulesWithAttribute_InheritedAttribute_IsRecognized" None

    [<Test>]
    member this.DependsOnModulesWithAttribute_NoMatchingModules_StillSucceeds() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "DependsOnModulesWithAttribute_NoMatchingModules_StillSucceeds" None

    [<Test>]
    member this.ModuleWithOverrideTags_IsRecognizedByTagDependency() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "ModuleWithOverrideTags_IsRecognizedByTagDependency" None

    [<Test>]
    member this.ModuleWithOverrideCategory_IsRecognizedByCategoryDependency() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "ModuleWithOverrideCategory_IsRecognizedByCategoryDependency" None

    [<Test>]
    member this.ModuleWithRegistrationTags_IsRecognizedByTagDependency() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "ModuleWithRegistrationTags_IsRecognizedByTagDependency" None

    [<Test>]
    member this.ModuleWithRegistrationCategory_IsRecognizedByCategoryDependency() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "ModuleWithRegistrationCategory_IsRecognizedByCategoryDependency" None

    [<Test>]
    member this.ModuleWithBothAttributeAndRegistrationTags_MergesTags() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "ModuleWithBothAttributeAndRegistrationTags_MergesTags" None

    [<Test>]
    member this.CombinedDependencies_ModuleWithMultipleFlexibleDependencies() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "CombinedDependencies_ModuleWithMultipleFlexibleDependencies" None

    [<Test>]
    member this.ChainedFlexibleDependencies_ExecuteInCorrectOrder() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.FlexibleDependencyIntegrationTests> "ChainedFlexibleDependencies_ExecuteInCorrectOrder" None
