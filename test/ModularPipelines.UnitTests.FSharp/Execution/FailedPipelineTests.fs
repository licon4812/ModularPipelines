namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type FailedPipelineTests() =
    inherit ModularPipelines.UnitTests.Execution.FailedPipelineTests()

    [<Test>]
    member this.Given_Failing_Module_With_Dependent_Module_When_Fail_Fast_Then_Failures_Propagate_Arguments1() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.FailedPipelineTests> "Given_Failing_Module_With_Dependent_Module_When_Fail_Fast_Then_Failures_Propagate" (Some 0)

    [<Test>]
    member this.Given_Failing_Module_With_Dependent_Module_When_Fail_Fast_Then_Failures_Propagate_Arguments2() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.FailedPipelineTests> "Given_Failing_Module_With_Dependent_Module_When_Fail_Fast_Then_Failures_Propagate" (Some 1)

    [<Test>]
    member this.Given_Failing_Module_When_Fail_Fast_Then_Failures_Propagate_Arguments1() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.FailedPipelineTests> "Given_Failing_Module_When_Fail_Fast_Then_Failures_Propagate" (Some 0)

    [<Test>]
    member this.Given_Failing_Module_When_Fail_Fast_Then_Failures_Propagate_Arguments2() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.FailedPipelineTests> "Given_Failing_Module_When_Fail_Fast_Then_Failures_Propagate" (Some 1)

    [<Test>]
    member this.Given_No_Failing_Module_Then_No_Exceptions_Arguments1() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.FailedPipelineTests> "Given_No_Failing_Module_Then_No_Exceptions" (Some 0)

    [<Test>]
    member this.Given_No_Failing_Module_Then_No_Exceptions_Arguments2() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.FailedPipelineTests> "Given_No_Failing_Module_Then_No_Exceptions" (Some 1)
