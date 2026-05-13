namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<TUnit.Core.NotInParallel(nameof(ExecutionHintTests))>]
type ExecutionHintTests() =
    inherit ModularPipelines.UnitTests.Execution.ExecutionHintTests()

    [<Test>]
    member this.ExecutionHintAttribute_CanBeAppliedToModule() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ExecutionHintTests> "ExecutionHintAttribute_CanBeAppliedToModule" None

    [<Test>]
    member this.ModulesWithoutExecutionHint_UseDefaultType() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ExecutionHintTests> "ModulesWithoutExecutionHint_UseDefaultType" None

    [<Test>]
    member this.AllExecutionTypes_ExecuteSuccessfully() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ExecutionHintTests> "AllExecutionTypes_ExecuteSuccessfully" None

    [<Test>]
    member this.CpuIntensiveModules_AreThrottled() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ExecutionHintTests> "CpuIntensiveModules_AreThrottled" None
