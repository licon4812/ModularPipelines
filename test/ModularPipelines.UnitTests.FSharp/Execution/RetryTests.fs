namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type RetryTests() =
    inherit ModularPipelines.UnitTests.Execution.RetryTests()

    [<Test>]
    member this.When_Successful_Do_Not_Retry() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.RetryTests> "When_Successful_Do_Not_Retry" None

    [<Test>]
    member this.When_Error_Then_Retry() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.RetryTests> "When_Error_Then_Retry" None

    [<Test>]
    member this.When_Error_With_Custom_RetryPolicy_Then_Retry() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.RetryTests> "When_Error_With_Custom_RetryPolicy_Then_Retry" None

    [<Test>]
    member this.When_Error_And_Zero_Retry_Count_Then_Do_Not_Retry() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.RetryTests> "When_Error_And_Zero_Retry_Count_Then_Do_Not_Retry" None

    [<Test>]
    member this.When_Retry_With_Timeout_Then_Honour_Overall_Timeout() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.RetryTests> "When_Retry_With_Timeout_Then_Honour_Overall_Timeout" None
