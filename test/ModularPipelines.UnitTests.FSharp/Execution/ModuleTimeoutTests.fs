namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleTimeoutTests() =
    inherit ModularPipelines.UnitTests.Execution.ModuleTimeoutTests()

    [<Test>]
    member this.Throws_TaskException_When_Using_CancellationToken() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ModuleTimeoutTests> "Throws_TaskException_When_Using_CancellationToken" None

    [<Test>]
    member this.Throws_Timeout_Exception_When_Not_Using_CancellationToken() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ModuleTimeoutTests> "Throws_Timeout_Exception_When_Not_Using_CancellationToken" None

    [<Test>]
    member this.No_Timeout_Does_Not_Throw_Exception() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ModuleTimeoutTests> "No_Timeout_Does_Not_Throw_Exception" None

    [<Test>]
    member this.Timeout_Exception_Contains_Configured_Timeout() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ModuleTimeoutTests> "Timeout_Exception_Contains_Configured_Timeout" None

    [<Test>]
    member this.Timeout_Exception_Contains_Module_Type() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ModuleTimeoutTests> "Timeout_Exception_Contains_Module_Type" None

    [<Test>]
    member this.Timeout_Exception_Contains_Elapsed_Time() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ModuleTimeoutTests> "Timeout_Exception_Contains_Elapsed_Time" None

    [<Test>]
    member this.Timeout_Exception_Indicates_Token_Was_Respected_When_Module_Uses_Token() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ModuleTimeoutTests> "Timeout_Exception_Indicates_Token_Was_Respected_When_Module_Uses_Token" None

    [<Test>]
    member this.Timeout_Exception_Indicates_Token_Was_Not_Respected_When_Module_Ignores_Token() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ModuleTimeoutTests> "Timeout_Exception_Indicates_Token_Was_Not_Respected_When_Module_Ignores_Token" None

    [<Test>]
    member this.Timeout_Exception_Message_Includes_Warning_When_Token_Ignored() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ModuleTimeoutTests> "Timeout_Exception_Message_Includes_Warning_When_Token_Ignored" None
