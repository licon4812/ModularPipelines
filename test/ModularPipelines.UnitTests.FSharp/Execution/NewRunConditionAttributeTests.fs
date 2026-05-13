namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type NewRunConditionAttributeTests() =
    inherit ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests()

    [<Test>]
    member this.EvaluateAsync() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "EvaluateAsync" None

    [<Test>]
    member this.EvaluateAsync() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "EvaluateAsync" None

    [<Test>]
    member this.NoConditions_ShouldRun() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "NoConditions_ShouldRun" None

    [<Test>]
    member this.RunIfAll_SingleTrueCondition_ShouldRun() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "RunIfAll_SingleTrueCondition_ShouldRun" None

    [<Test>]
    member this.RunIfAll_SingleFalseCondition_ShouldSkip() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "RunIfAll_SingleFalseCondition_ShouldSkip" None

    [<Test>]
    member this.RunIfAll_MixedConditions_ShouldSkip() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "RunIfAll_MixedConditions_ShouldSkip" None

    [<Test>]
    member this.RunIfAny_SingleTrueCondition_ShouldRun() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "RunIfAny_SingleTrueCondition_ShouldRun" None

    [<Test>]
    member this.RunIfAny_SingleFalseCondition_ShouldSkip() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "RunIfAny_SingleFalseCondition_ShouldSkip" None

    [<Test>]
    member this.RunIfAny_MixedConditions_ShouldRun() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "RunIfAny_MixedConditions_ShouldRun" None

    [<Test>]
    member this.SkipIf_TrueCondition_ShouldSkip() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "SkipIf_TrueCondition_ShouldSkip" None

    [<Test>]
    member this.SkipIf_FalseCondition_ShouldRun() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "SkipIf_FalseCondition_ShouldRun" None

    [<Test>]
    member this.SkipIf_EvaluatedBeforeRunIfAll_ShouldSkip() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "SkipIf_EvaluatedBeforeRunIfAll_ShouldSkip" None

    [<Test>]
    member this.MultipleRunIfAll_AllTrue_ShouldRun() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "MultipleRunIfAll_AllTrue_ShouldRun" None

    [<Test>]
    member this.MultipleRunIfAll_OneFails_ShouldSkip() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "MultipleRunIfAll_OneFails_ShouldSkip" None

    [<Test>]
    member this.ConditionGroup_TrueGroup_ShouldRun() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "ConditionGroup_TrueGroup_ShouldRun" None

    [<Test>]
    member this.ConditionGroup_FalseGroup_ShouldSkip() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "ConditionGroup_FalseGroup_ShouldSkip" None
