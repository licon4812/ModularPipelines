namespace ModularPipelines.UnitTests.FSharp.Configuration

open ModularPipelines.UnitTests.Configuration
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleConfigurationTests() =
    inherit ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "Default_SkipCondition_IsNull" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "Default_Timeout_IsNull" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "Default_RetryPolicyFactory_IsNull" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "Default_IgnoreFailuresCondition_IsNull" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "Default_AlwaysRun_IsFalse" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "Default_OnBeforeExecute_IsNull" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "Default_OnAfterExecute_IsNull" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "Create_ReturnsBuilder" 0 None

    [<Test>]
    member this.Test_9() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithSkipWhen_SyncBool_SetsSkipCondition" 0 None

    [<Test>]
    member this.Test_10() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithSkipWhen_SyncBoolFalse_ReturnsDoNotSkip" 0 None

    [<Test>]
    member this.Test_11() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithSkipWhen_AsyncBool_SetsSkipCondition" 0 None

    [<Test>]
    member this.Test_12() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithSkipWhen_SyncSkipDecision_SetsSkipCondition" 0 None

    [<Test>]
    member this.Test_13() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithSkipWhen_AsyncSkipDecision_SetsSkipCondition" 0 None

    [<Test>]
    member this.Test_14() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithSkipWhen_WithContext_SyncBool_SetsSkipCondition" 0 None

    [<Test>]
    member this.Test_15() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithSkipWhen_WithContext_AsyncBool_SetsSkipCondition" 0 None

    [<Test>]
    member this.Test_16() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithSkipWhen_WithContext_SyncSkipDecision_SetsSkipCondition" 0 None

    [<Test>]
    member this.Test_17() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithSkipWhen_WithContext_AsyncSkipDecision_SetsSkipCondition" 0 None

    [<Test>]
    member this.Test_18() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithTimeout_SetsTimeout" 0 None

    [<Test>]
    member this.Test_19() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithRetryPolicy_Direct_SetsRetryPolicyFactory" 0 None

    [<Test>]
    member this.Test_20() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithRetryPolicy_Factory_SetsRetryPolicyFactory" 0 None

    [<Test>]
    member this.Test_21() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithRetryCount_SetsRetryPolicyFactory" 0 None

    [<Test>]
    member this.Test_22() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithIgnoreFailures_Always_SetsIgnoreFailuresCondition" 0 None

    [<Test>]
    member this.Test_23() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithIgnoreFailuresWhen_SyncCondition_SetsIgnoreFailuresCondition" 0 None

    [<Test>]
    member this.Test_24() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithIgnoreFailuresWhen_AsyncCondition_SetsIgnoreFailuresCondition" 0 None

    [<Test>]
    member this.Test_25() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithAlwaysRun_SetsAlwaysRun" 0 None

    [<Test>]
    member this.Test_26() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithBeforeExecute_SetsOnBeforeExecute" 0 None

    [<Test>]
    member this.Test_27() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithAfterExecute_SetsOnAfterExecute" 0 None

    [<Test>]
    member this.Test_28() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "Builder_FluentChaining_AllMethodsChain" 0 None

