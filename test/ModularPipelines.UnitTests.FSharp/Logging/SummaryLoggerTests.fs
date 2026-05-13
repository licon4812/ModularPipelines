namespace ModularPipelines.UnitTests.FSharp.Logging

open ModularPipelines.UnitTests.Logging
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type SummaryLoggerTests() =
    inherit ModularPipelines.UnitTests.Logging.SummaryLoggerTests()

    [<Test>]
    member this.SummaryApi_Info_LogsCorrectly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "SummaryApi_Info_LogsCorrectly" None

    [<Test>]
    member this.SummaryApi_Success_LogsCorrectly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "SummaryApi_Success_LogsCorrectly" None

    [<Test>]
    member this.SummaryApi_Warning_LogsCorrectly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "SummaryApi_Warning_LogsCorrectly" None

    [<Test>]
    member this.SummaryApi_Error_LogsCorrectly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "SummaryApi_Error_LogsCorrectly" None

    [<Test>]
    member this.SummaryApi_KeyValue_LogsCorrectly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "SummaryApi_KeyValue_LogsCorrectly" None

    [<Test>]
    member this.SummaryApi_Category_LogsCorrectly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "SummaryApi_Category_LogsCorrectly" None

    [<Test>]
    member this.GetEntries_ReturnsAllEntries() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "GetEntries_ReturnsAllEntries" None

    [<Test>]
    member this.GetEntries_WithCategory_FiltersCorrectly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "GetEntries_WithCategory_FiltersCorrectly" None

    [<Test>]
    member this.GetOutput_FormatsCorrectly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "GetOutput_FormatsCorrectly" None

    [<Test>]
    member this.GetOutput_GroupsByCategory() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "GetOutput_GroupsByCategory" None

    [<Test>]
    member this.Log_WithLevel_AddsCorrectEntry() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "Log_WithLevel_AddsCorrectEntry" None

    [<Test>]
    member this.Log_WithLevelAndCategory_AddsCorrectEntry() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "Log_WithLevelAndCategory_AddsCorrectEntry" None

    [<Test>]
    member this.ConcurrentLogging_IsThreadSafe() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SummaryLoggerTests> "ConcurrentLogging_IsThreadSafe" None
