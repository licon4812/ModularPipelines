namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type FailedPipelineTests() =
    inherit ModularPipelines.UnitTests.Execution.FailedPipelineTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.FailedPipelineTests> "Given_Failing_Module_With_Dependent_Module_When_Fail_Fast_Then_Failures_Propagate" 0 (Some 0)

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.FailedPipelineTests> "Given_Failing_Module_With_Dependent_Module_When_Fail_Fast_Then_Failures_Propagate" 0 (Some 1)

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.FailedPipelineTests> "Given_Failing_Module_When_Fail_Fast_Then_Failures_Propagate" 0 (Some 0)

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.FailedPipelineTests> "Given_Failing_Module_When_Fail_Fast_Then_Failures_Propagate" 0 (Some 1)

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.FailedPipelineTests> "Given_No_Failing_Module_Then_No_Exceptions" 0 (Some 0)

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.FailedPipelineTests> "Given_No_Failing_Module_Then_No_Exceptions" 0 (Some 1)

