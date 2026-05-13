namespace ModularPipelines.UnitTests.FSharp.Hooks

open ModularPipelines.UnitTests.Hooks
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DirectModuleHooksTests() =
    inherit ModularPipelines.UnitTests.Hooks.DirectModuleHooksTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksTests> "OnBeforeExecuteAsync_CalledBeforeExecuteAsync" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksTests> "OnAfterExecuteAsync_CalledAfterExecuteAsync" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksTests> "OnSkippedAsync_CalledWhenModuleSkipped" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksTests> "OnFailedAsync_CalledWhenModuleFails" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksTests> "OnAfterExecuteAsync_CalledWhenModuleFails" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksTests> "DirectHooks_CalledBeforeConfigHooks" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksTests> "OnBeforeExecuteAsync_ExceptionPreventsExecution" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksTests> "OnAfterExecuteAsync_ExceptionLogged_ResultPreserved" 0 None

    [<Test>]
    member this.Test_9() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Hooks.DirectModuleHooksTests> "Module_WithNoOverrides_ExecutesNormally" 0 None

