namespace ModularPipelines.UnitTests.FSharp.Hooks

open ModularPipelines.UnitTests.Hooks
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<NotInParallel(nameof(DirectModuleHooksIntegrationTests))>]
type DirectModuleHooksIntegrationTests() =
    inherit ModularPipelines.UnitTests.Hooks.DirectModuleHooksIntegrationTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksIntegrationTests> "FullPipeline_WithMultipleModules_HooksExecuteInCorrectOrder" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksIntegrationTests> "HookOrdering_DirectHooksRunBeforeConfigHooks" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksIntegrationTests> "DependentModule_HooksExecuteWithCorrectDependencyOrder" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksIntegrationTests> "Context_IsAvailableInHooks" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksIntegrationTests> "Pipeline_CompletesSuccessfully_WithAllHooksExecuted" 0 None

