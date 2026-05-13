namespace ModularPipelines.UnitTests.FSharp.Context

open ModularPipelines.UnitTests.Context
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type HttpTests() =
    inherit ModularPipelines.UnitTests.Context.HttpTests()

    [<Test>]
    member this.Can_Send_Request_With_String_To_Request_Implicit_Conversion() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.HttpTests> "Can_Send_Request_With_String_To_Request_Implicit_Conversion" None

    [<Test>]
    member this.When_Log_Request_False_Then_Do_Not_Log_Request() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.HttpTests> "When_Log_Request_False_Then_Do_Not_Log_Request" None

    [<Test>]
    member this.When_Log_Response_False_Then_Do_Not_Log_Response() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.HttpTests> "When_Log_Response_False_Then_Do_Not_Log_Response" None

    [<Test>]
    member this.Assert_LoggingHttpClient_Logs_As_Expected_Arguments1() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.HttpTests> "Assert_LoggingHttpClient_Logs_As_Expected" (Some 0)

    [<Test>]
    member this.Assert_LoggingHttpClient_Logs_As_Expected_Arguments2() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.HttpTests> "Assert_LoggingHttpClient_Logs_As_Expected" (Some 1)
