namespace ModularPipelines.UnitTests.FSharp.Logging

open ModularPipelines.UnitTests.Logging
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleLoggerTests() =
    inherit ModularPipelines.UnitTests.Logging.ModuleLoggerTests()

    [<Test>]
    member this.LogToConsole_Does_Not_Write_To_File_Logger() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.ModuleLoggerTests> "LogToConsole_Does_Not_Write_To_File_Logger" None

    [<Test>]
    member this.Can_Obfuscate_Secret_Arguments1() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.ModuleLoggerTests> "Can_Obfuscate_Secret" (Some 0)

    [<Test>]
    member this.Can_Obfuscate_Secret_Arguments2() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.ModuleLoggerTests> "Can_Obfuscate_Secret" (Some 1)
