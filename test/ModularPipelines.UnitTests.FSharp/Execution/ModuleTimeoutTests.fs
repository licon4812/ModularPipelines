namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleTimeoutTests() =
    inherit ModularPipelines.UnitTests.Execution.ModuleTimeoutTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ModuleTimeoutTests> "Throws_TaskException_When_Using_CancellationToken" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ModuleTimeoutTests> "Throws_Timeout_Exception_When_Not_Using_CancellationToken" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ModuleTimeoutTests> "No_Timeout_Does_Not_Throw_Exception" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ModuleTimeoutTests> "Timeout_Exception_Contains_Configured_Timeout" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ModuleTimeoutTests> "Timeout_Exception_Contains_Module_Type" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ModuleTimeoutTests> "Timeout_Exception_Contains_Elapsed_Time" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ModuleTimeoutTests> "Timeout_Exception_Indicates_Token_Was_Respected_When_Module_Uses_Token" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ModuleTimeoutTests> "Timeout_Exception_Indicates_Token_Was_Not_Respected_When_Module_Ignores_Token" 0 None

    [<Test>]
    member this.Test_9() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ModuleTimeoutTests> "Timeout_Exception_Message_Includes_Warning_When_Token_Ignored" 0 None

