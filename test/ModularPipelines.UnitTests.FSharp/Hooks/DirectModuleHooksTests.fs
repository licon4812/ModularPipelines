namespace ModularPipelines.UnitTests.FSharp.Hooks

open ModularPipelines.UnitTests.Hooks
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DirectModuleHooksTests() =
    inherit ModularPipelines.UnitTests.Hooks.DirectModuleHooksTests()

    [<Test>]
    member this.OnBeforeExecuteAsync_CalledBeforeExecuteAsync() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksTests> "OnBeforeExecuteAsync_CalledBeforeExecuteAsync" None

    [<Test>]
    member this.OnAfterExecuteAsync_CalledAfterExecuteAsync() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksTests> "OnAfterExecuteAsync_CalledAfterExecuteAsync" None

    [<Test>]
    member this.OnSkippedAsync_CalledWhenModuleSkipped() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksTests> "OnSkippedAsync_CalledWhenModuleSkipped" None

    [<Test>]
    member this.OnFailedAsync_CalledWhenModuleFails() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksTests> "OnFailedAsync_CalledWhenModuleFails" None

    [<Test>]
    member this.OnAfterExecuteAsync_CalledWhenModuleFails() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksTests> "OnAfterExecuteAsync_CalledWhenModuleFails" None

    [<Test>]
    member this.DirectHooks_CalledBeforeConfigHooks() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksTests> "DirectHooks_CalledBeforeConfigHooks" None

    [<Test>]
    member this.OnBeforeExecuteAsync_ExceptionPreventsExecution() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksTests> "OnBeforeExecuteAsync_ExceptionPreventsExecution" None

    [<Test>]
    member this.OnAfterExecuteAsync_ExceptionLogged_ResultPreserved() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksTests> "OnAfterExecuteAsync_ExceptionLogged_ResultPreserved" None

    [<Test>]
    member this.Module_WithNoOverrides_ExecutesNormally() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksTests> "Module_WithNoOverrides_ExecutesNormally" None
