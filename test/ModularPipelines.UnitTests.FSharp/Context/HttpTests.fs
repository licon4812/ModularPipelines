namespace ModularPipelines.UnitTests.FSharp.Context

open ModularPipelines.UnitTests.Context
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type HttpTests() =
    inherit ModularPipelines.UnitTests.Context.HttpTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.HttpTests> "Can_Send_Request_With_String_To_Request_Implicit_Conversion" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.HttpTests> "When_Log_Request_False_Then_Do_Not_Log_Request" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.HttpTests> "When_Log_Response_False_Then_Do_Not_Log_Response" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.HttpTests> "Assert_LoggingHttpClient_Logs_As_Expected" 0 (Some 0)

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.HttpTests> "Assert_LoggingHttpClient_Logs_As_Expected" 0 (Some 1)

