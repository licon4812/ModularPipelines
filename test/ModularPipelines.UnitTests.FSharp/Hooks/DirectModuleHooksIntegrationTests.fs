namespace ModularPipelines.UnitTests.FSharp.Hooks

open ModularPipelines.UnitTests.Hooks
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<NotInParallel(nameof(DirectModuleHooksIntegrationTests))>]
type DirectModuleHooksIntegrationTests() =
    inherit ModularPipelines.UnitTests.Hooks.DirectModuleHooksIntegrationTests()

    [<Test>]
    member this.FullPipeline_WithMultipleModules_HooksExecuteInCorrectOrder() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksIntegrationTests> "FullPipeline_WithMultipleModules_HooksExecuteInCorrectOrder" None

    [<Test>]
    member this.HookOrdering_DirectHooksRunBeforeConfigHooks() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksIntegrationTests> "HookOrdering_DirectHooksRunBeforeConfigHooks" None

    [<Test>]
    member this.DependentModule_HooksExecuteWithCorrectDependencyOrder() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksIntegrationTests> "DependentModule_HooksExecuteWithCorrectDependencyOrder" None

    [<Test>]
    member this.Context_IsAvailableInHooks() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksIntegrationTests> "Context_IsAvailableInHooks" None

    [<Test>]
    member this.Pipeline_CompletesSuccessfully_WithAllHooksExecuted() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksIntegrationTests> "Pipeline_CompletesSuccessfully_WithAllHooksExecuted" None
