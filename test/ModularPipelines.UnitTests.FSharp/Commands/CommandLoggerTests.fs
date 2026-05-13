namespace ModularPipelines.UnitTests.FSharp.Commands

open ModularPipelines.UnitTests.Commands
open TUnit.Core

type CommandLoggerTests() =
    inherit ModularPipelines.UnitTests.Commands.CommandLoggerTests()

    [<Test>]
    [<MatrixDataSource>]
    member _.Test_1(
        [<Matrix(true, false)>] logInput: bool,
        [<Matrix(true, false)>] logOutput: bool,
        [<Matrix(true, false)>] logError: bool,
        [<Matrix(true, false)>] logExitCode: bool,
        [<Matrix(true, false)>] logDuration: bool
    ) =
        let result = base.Logs_As_Expected_With_Options(logInput, logOutput, logError, logExitCode, logDuration)
        async { do! result |> Async.AwaitTask }

    [<Test>]
    member _.Test_2() =
        let result = base.Silent_Verbosity_Logs_Nothing()
        async { do! result |> Async.AwaitTask }

    [<Test>]
    member _.Test_3() =
        let result = base.Minimal_Verbosity_Logs_Only_Input()
        async { do! result |> Async.AwaitTask }

    [<Test>]
    member _.Test_4() =
        let result = base.Normal_Verbosity_Logs_Input_And_Output()
        async { do! result |> Async.AwaitTask }

    [<Test>]
    member _.Test_5() =
        let result = base.Detailed_Verbosity_Logs_Input_Output_ExitCode_Duration()
        async { do! result |> Async.AwaitTask }

    [<Test>]
    member _.Test_6() =
        let result = base.Diagnostic_Verbosity_Logs_Everything_Including_WorkingDirectory()
        async { do! result |> Async.AwaitTask }
