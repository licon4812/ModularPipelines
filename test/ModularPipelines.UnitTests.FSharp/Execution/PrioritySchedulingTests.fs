namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<TUnit.Core.NotInParallel(nameof(PrioritySchedulingTests))>]
type PrioritySchedulingTests() =
    inherit ModularPipelines.UnitTests.Execution.PrioritySchedulingTests()

    [<Test>]
    member this.PriorityAttribute_CanBeAppliedToModule() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.PrioritySchedulingTests> "PriorityAttribute_CanBeAppliedToModule" None

    [<Test>]
    member this.ModulesWithoutPriorityAttribute_UseNormalPriority() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.PrioritySchedulingTests> "ModulesWithoutPriorityAttribute_UseNormalPriority" None

    [<Test>]
    member this.AllPriorityLevels_ExecuteSuccessfully() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.PrioritySchedulingTests> "AllPriorityLevels_ExecuteSuccessfully" None
