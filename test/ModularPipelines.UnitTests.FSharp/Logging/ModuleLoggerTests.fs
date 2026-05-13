namespace ModularPipelines.UnitTests.FSharp.Logging

open ModularPipelines.UnitTests.Logging
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleLoggerTests() =
    inherit ModularPipelines.UnitTests.Logging.ModuleLoggerTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.ModuleLoggerTests> "LogToConsole_Does_Not_Write_To_File_Logger" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.ModuleLoggerTests> "Can_Obfuscate_Secret" 0 (Some 0)

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.ModuleLoggerTests> "Can_Obfuscate_Secret" 0 (Some 1)

