namespace ModularPipelines.UnitTests.FSharp.Commands

open ModularPipelines.UnitTests.Commands
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type CommandLoggerTests() =
    inherit ModularPipelines.UnitTests.Commands.CommandLoggerTests()

    [<Test>]
    [<MatrixDataSource>]
    member this.Logs_As_Expected_With_Options() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Commands.CommandLoggerTests> "Logs_As_Expected_With_Options" None

    [<Test>]
    member this.Silent_Verbosity_Logs_Nothing() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Commands.CommandLoggerTests> "Silent_Verbosity_Logs_Nothing" None

    [<Test>]
    member this.Minimal_Verbosity_Logs_Only_Input() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Commands.CommandLoggerTests> "Minimal_Verbosity_Logs_Only_Input" None

    [<Test>]
    member this.Normal_Verbosity_Logs_Input_And_Output() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Commands.CommandLoggerTests> "Normal_Verbosity_Logs_Input_And_Output" None

    [<Test>]
    member this.Detailed_Verbosity_Logs_Input_Output_ExitCode_Duration() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Commands.CommandLoggerTests> "Detailed_Verbosity_Logs_Input_Output_ExitCode_Duration" None

    [<Test>]
    member this.Diagnostic_Verbosity_Logs_Everything_Including_WorkingDirectory() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Commands.CommandLoggerTests> "Diagnostic_Verbosity_Logs_Everything_Including_WorkingDirectory" None
