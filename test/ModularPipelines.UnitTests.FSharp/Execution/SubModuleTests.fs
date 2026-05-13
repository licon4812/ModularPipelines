namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type SubModuleTests() =
    inherit ModularPipelines.UnitTests.Execution.SubModuleTests()

    [<Test>]
    member this.Submodule_With_Progress() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.SubModuleTests> "Submodule_With_Progress" None

    [<Test>]
    member this.Submodule_With_Return_Type_Does_Not_Fail_And_Runs_Once() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.SubModuleTests> "Submodule_With_Return_Type_Does_Not_Fail_And_Runs_Once" None

    [<Test>]
    member this.Submodule_Without_Return_Type_Does_Not_Fail_And_Runs_Once() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.SubModuleTests> "Submodule_Without_Return_Type_Does_Not_Fail_And_Runs_Once" None

    [<Test>]
    member this.Submodule_With_Return_Type_Does_Not_Fail_Synchronous_And_Runs_Once() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.SubModuleTests> "Submodule_With_Return_Type_Does_Not_Fail_Synchronous_And_Runs_Once" None

    [<Test>]
    member this.Submodule_Without_Return_Type_Does_Not_Fail_Synchronous_And_Runs_Once() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.SubModuleTests> "Submodule_Without_Return_Type_Does_Not_Fail_Synchronous_And_Runs_Once" None

    [<Test>]
    member this.Failing_Submodule_With_Return_Type_Fails() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.SubModuleTests> "Failing_Submodule_With_Return_Type_Fails" None

    [<Test>]
    member this.Failing_Submodule_Without_Return_Type_Fails() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.SubModuleTests> "Failing_Submodule_Without_Return_Type_Fails" None

    [<Test>]
    member this.Failing_Submodule_With_Return_Type_Fails_Synchronous() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.SubModuleTests> "Failing_Submodule_With_Return_Type_Fails_Synchronous" None

    [<Test>]
    member this.Failing_Submodule_Without_Return_Type_Fails_Synchronous() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.SubModuleTests> "Failing_Submodule_Without_Return_Type_Fails_Synchronous" None

    [<Test>]
    member this.Module_With_Retry_Policy_Retries_Entire_Execution() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.SubModuleTests> "Module_With_Retry_Policy_Retries_Entire_Execution" None

    [<Test>]
    member this.Module_With_Retry_Policy_Retries_Entire_Execution_With_Return_Type() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.SubModuleTests> "Module_With_Retry_Policy_Retries_Entire_Execution_With_Return_Type" None
