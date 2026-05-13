namespace ModularPipelines.UnitTests.FSharp.Configuration

open ModularPipelines.UnitTests.Configuration
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleConfigurationTests() =
    inherit ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests()

    [<Test>]
    member this.Default_SkipCondition_IsNull() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "Default_SkipCondition_IsNull" None

    [<Test>]
    member this.Default_Timeout_IsNull() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "Default_Timeout_IsNull" None

    [<Test>]
    member this.Default_RetryPolicyFactory_IsNull() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "Default_RetryPolicyFactory_IsNull" None

    [<Test>]
    member this.Default_IgnoreFailuresCondition_IsNull() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "Default_IgnoreFailuresCondition_IsNull" None

    [<Test>]
    member this.Default_AlwaysRun_IsFalse() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "Default_AlwaysRun_IsFalse" None

    [<Test>]
    member this.Default_OnBeforeExecute_IsNull() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "Default_OnBeforeExecute_IsNull" None

    [<Test>]
    member this.Default_OnAfterExecute_IsNull() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "Default_OnAfterExecute_IsNull" None

    [<Test>]
    member this.Create_ReturnsBuilder() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "Create_ReturnsBuilder" None

    [<Test>]
    member this.WithSkipWhen_SyncBool_SetsSkipCondition() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithSkipWhen_SyncBool_SetsSkipCondition" None

    [<Test>]
    member this.WithSkipWhen_SyncBoolFalse_ReturnsDoNotSkip() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithSkipWhen_SyncBoolFalse_ReturnsDoNotSkip" None

    [<Test>]
    member this.WithSkipWhen_AsyncBool_SetsSkipCondition() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithSkipWhen_AsyncBool_SetsSkipCondition" None

    [<Test>]
    member this.WithSkipWhen_SyncSkipDecision_SetsSkipCondition() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithSkipWhen_SyncSkipDecision_SetsSkipCondition" None

    [<Test>]
    member this.WithSkipWhen_AsyncSkipDecision_SetsSkipCondition() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithSkipWhen_AsyncSkipDecision_SetsSkipCondition" None

    [<Test>]
    member this.WithSkipWhen_WithContext_SyncBool_SetsSkipCondition() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithSkipWhen_WithContext_SyncBool_SetsSkipCondition" None

    [<Test>]
    member this.WithSkipWhen_WithContext_AsyncBool_SetsSkipCondition() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithSkipWhen_WithContext_AsyncBool_SetsSkipCondition" None

    [<Test>]
    member this.WithSkipWhen_WithContext_SyncSkipDecision_SetsSkipCondition() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithSkipWhen_WithContext_SyncSkipDecision_SetsSkipCondition" None

    [<Test>]
    member this.WithSkipWhen_WithContext_AsyncSkipDecision_SetsSkipCondition() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithSkipWhen_WithContext_AsyncSkipDecision_SetsSkipCondition" None

    [<Test>]
    member this.WithTimeout_SetsTimeout() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithTimeout_SetsTimeout" None

    [<Test>]
    member this.WithRetryPolicy_Direct_SetsRetryPolicyFactory() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithRetryPolicy_Direct_SetsRetryPolicyFactory" None

    [<Test>]
    member this.WithRetryPolicy_Factory_SetsRetryPolicyFactory() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithRetryPolicy_Factory_SetsRetryPolicyFactory" None

    [<Test>]
    member this.WithRetryCount_SetsRetryPolicyFactory() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithRetryCount_SetsRetryPolicyFactory" None

    [<Test>]
    member this.WithIgnoreFailures_Always_SetsIgnoreFailuresCondition() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithIgnoreFailures_Always_SetsIgnoreFailuresCondition" None

    [<Test>]
    member this.WithIgnoreFailuresWhen_SyncCondition_SetsIgnoreFailuresCondition() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithIgnoreFailuresWhen_SyncCondition_SetsIgnoreFailuresCondition" None

    [<Test>]
    member this.WithIgnoreFailuresWhen_AsyncCondition_SetsIgnoreFailuresCondition() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithIgnoreFailuresWhen_AsyncCondition_SetsIgnoreFailuresCondition" None

    [<Test>]
    member this.WithAlwaysRun_SetsAlwaysRun() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithAlwaysRun_SetsAlwaysRun" None

    [<Test>]
    member this.WithBeforeExecute_SetsOnBeforeExecute() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithBeforeExecute_SetsOnBeforeExecute" None

    [<Test>]
    member this.WithAfterExecute_SetsOnAfterExecute() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "WithAfterExecute_SetsOnAfterExecute" None

    [<Test>]
    member this.Builder_FluentChaining_AllMethodsChain() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Configuration.ModuleConfigurationTests> "Builder_FluentChaining_AllMethodsChain" None
