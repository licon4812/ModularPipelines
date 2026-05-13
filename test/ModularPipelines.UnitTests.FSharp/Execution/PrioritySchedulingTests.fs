namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<TUnit.Core.NotInParallel(nameof(PrioritySchedulingTests))>]
type PrioritySchedulingTests() =
    inherit ModularPipelines.UnitTests.Execution.PrioritySchedulingTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.PrioritySchedulingTests> "PriorityAttribute_CanBeAppliedToModule" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.PrioritySchedulingTests> "ModulesWithoutPriorityAttribute_UseNormalPriority" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.PrioritySchedulingTests> "AllPriorityLevels_ExecuteSuccessfully" 0 None

