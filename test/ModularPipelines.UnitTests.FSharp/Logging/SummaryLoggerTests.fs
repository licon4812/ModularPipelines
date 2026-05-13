namespace ModularPipelines.UnitTests.FSharp.Logging

open ModularPipelines.UnitTests.Logging
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type SummaryLoggerTests() =
    inherit ModularPipelines.UnitTests.Logging.SummaryLoggerTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "SummaryApi_Info_LogsCorrectly" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "SummaryApi_Success_LogsCorrectly" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "SummaryApi_Warning_LogsCorrectly" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "SummaryApi_Error_LogsCorrectly" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "SummaryApi_KeyValue_LogsCorrectly" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "SummaryApi_Category_LogsCorrectly" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "GetEntries_ReturnsAllEntries" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "GetEntries_WithCategory_FiltersCorrectly" 0 None

    [<Test>]
    member this.Test_9() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "GetOutput_FormatsCorrectly" 0 None

    [<Test>]
    member this.Test_10() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "GetOutput_GroupsByCategory" 0 None

    [<Test>]
    member this.Test_11() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "Log_WithLevel_AddsCorrectEntry" 0 None

    [<Test>]
    member this.Test_12() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "Log_WithLevelAndCategory_AddsCorrectEntry" 0 None

    [<Test>]
    member this.Test_13() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "ConcurrentLogging_IsThreadSafe" 0 None

