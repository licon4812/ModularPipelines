namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type SubModuleTests() =
    inherit ModularPipelines.UnitTests.Execution.SubModuleTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.SubModuleTests> "Submodule_With_Progress" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.SubModuleTests> "Submodule_With_Return_Type_Does_Not_Fail_And_Runs_Once" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.SubModuleTests> "Submodule_Without_Return_Type_Does_Not_Fail_And_Runs_Once" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.SubModuleTests> "Submodule_With_Return_Type_Does_Not_Fail_Synchronous_And_Runs_Once" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.SubModuleTests> "Submodule_Without_Return_Type_Does_Not_Fail_Synchronous_And_Runs_Once" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.SubModuleTests> "Failing_Submodule_With_Return_Type_Fails" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.SubModuleTests> "Failing_Submodule_Without_Return_Type_Fails" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.SubModuleTests> "Failing_Submodule_With_Return_Type_Fails_Synchronous" 0 None

    [<Test>]
    member this.Test_9() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.SubModuleTests> "Failing_Submodule_Without_Return_Type_Fails_Synchronous" 0 None

    [<Test>]
    member this.Test_10() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.SubModuleTests> "Module_With_Retry_Policy_Retries_Entire_Execution" 0 None

    [<Test>]
    member this.Test_11() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.SubModuleTests> "Module_With_Retry_Policy_Retries_Entire_Execution_With_Return_Type" 0 None

