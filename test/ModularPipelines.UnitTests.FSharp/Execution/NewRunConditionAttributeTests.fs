namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type NewRunConditionAttributeTests() =
    inherit ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "NoConditions_ShouldRun" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "RunIfAll_SingleTrueCondition_ShouldRun" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "RunIfAll_SingleFalseCondition_ShouldSkip" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "RunIfAll_MixedConditions_ShouldSkip" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "RunIfAny_SingleTrueCondition_ShouldRun" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "RunIfAny_SingleFalseCondition_ShouldSkip" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "RunIfAny_MixedConditions_ShouldRun" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "SkipIf_TrueCondition_ShouldSkip" 0 None

    [<Test>]
    member this.Test_9() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "SkipIf_FalseCondition_ShouldRun" 0 None

    [<Test>]
    member this.Test_10() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "SkipIf_EvaluatedBeforeRunIfAll_ShouldSkip" 0 None

    [<Test>]
    member this.Test_11() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "MultipleRunIfAll_AllTrue_ShouldRun" 0 None

    [<Test>]
    member this.Test_12() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "MultipleRunIfAll_OneFails_ShouldSkip" 0 None

    [<Test>]
    member this.Test_13() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "ConditionGroup_TrueGroup_ShouldRun" 0 None

    [<Test>]
    member this.Test_14() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.NewRunConditionAttributeTests> "ConditionGroup_FalseGroup_ShouldSkip" 0 None

