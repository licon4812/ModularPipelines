namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<TUnit.Core.NotInParallel(nameof(ExecutionHintTests))>]
type ExecutionHintTests() =
    inherit ModularPipelines.UnitTests.Execution.ExecutionHintTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ExecutionHintTests> "ExecutionHintAttribute_CanBeAppliedToModule" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ExecutionHintTests> "ModulesWithoutExecutionHint_UseDefaultType" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ExecutionHintTests> "AllExecutionTypes_ExecuteSuccessfully" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ExecutionHintTests> "CpuIntensiveModules_AreThrottled" 0 None

