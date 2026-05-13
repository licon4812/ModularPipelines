namespace ModularPipelines.UnitTests.FSharp.Builders

open ModularPipelines.UnitTests.Builders
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type CommandBuilderBaseTests() =
    inherit ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithWorkingDirectory_SetsWorkingDirectory" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithTimeout_SetsTimeout" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithEnvironmentVariable_AddsVariable" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithEnvironmentVariable_AddsMultipleVariables" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithEnvironmentVariables_AddsDictionary" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithSudo_EnablesSudo" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithSudo_DisablesSudo_WhenFalse" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithThrowOnError_EnablesThrowOnError" 0 None

    [<Test>]
    member this.Test_9() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithThrowOnError_DisablesThrowOnError_WhenFalse" 0 None

    [<Test>]
    member this.Test_10() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithGracefulShutdownTimeout_SetsTimeout" 0 None

    [<Test>]
    member this.Test_11() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithLogging_SetsLoggingOptions" 0 None

    [<Test>]
    member this.Test_12() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithLogging_ConfiguresUsingAction" 0 None

    [<Test>]
    member this.Test_13() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "ToolSpecificOption_SetsToolOptions" 0 None

    [<Test>]
    member this.Test_14() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "InitialOptions_UsesProvidedOptions" 0 None

    [<Test>]
    member this.Test_15() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "InitialOptions_CanBeModified" 0 None

    [<Test>]
    member this.Test_16() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "FluentChaining_SetsAllOptions" 0 None

    [<Test>]
    member this.Test_17() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "FluentChaining_ReturnsSameBuilderInstance" 0 None

    [<Test>]
    member this.Test_18() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "ExecuteAsync_CallsCommandExecuteWithOptions" 0 None

    [<Test>]
    member this.Test_19() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "ExecuteAsync_PassesCancellationToken" 0 None

    [<Test>]
    member this.Test_20() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "ExecuteAsync_PassesExecutionOptions" 0 None

    [<Test>]
    member this.Test_21() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "ToOptions_ReturnsBothOptionsTuple" 0 None

    [<Test>]
    member this.Test_22() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "ToOptions_CanBeCalledMultipleTimes" 0 None

    [<Test>]
    member this.Test_23() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "NonGenericInterface_CanBeUsedForChaining" 0 None

