namespace ModularPipelines.UnitTests.FSharp.Builders

open ModularPipelines.UnitTests.Builders
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type CommandBuilderBaseTests() =
    inherit ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests()

    [<Test>]
    member this.WithWorkingDirectory_SetsWorkingDirectory() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithWorkingDirectory_SetsWorkingDirectory" None

    [<Test>]
    member this.WithTimeout_SetsTimeout() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithTimeout_SetsTimeout" None

    [<Test>]
    member this.WithEnvironmentVariable_AddsVariable() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithEnvironmentVariable_AddsVariable" None

    [<Test>]
    member this.WithEnvironmentVariable_AddsMultipleVariables() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithEnvironmentVariable_AddsMultipleVariables" None

    [<Test>]
    member this.WithEnvironmentVariables_AddsDictionary() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithEnvironmentVariables_AddsDictionary" None

    [<Test>]
    member this.WithSudo_EnablesSudo() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithSudo_EnablesSudo" None

    [<Test>]
    member this.WithSudo_DisablesSudo_WhenFalse() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithSudo_DisablesSudo_WhenFalse" None

    [<Test>]
    member this.WithThrowOnError_EnablesThrowOnError() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithThrowOnError_EnablesThrowOnError" None

    [<Test>]
    member this.WithThrowOnError_DisablesThrowOnError_WhenFalse() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithThrowOnError_DisablesThrowOnError_WhenFalse" None

    [<Test>]
    member this.WithGracefulShutdownTimeout_SetsTimeout() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithGracefulShutdownTimeout_SetsTimeout" None

    [<Test>]
    member this.WithLogging_SetsLoggingOptions() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithLogging_SetsLoggingOptions" None

    [<Test>]
    member this.WithLogging_ConfiguresUsingAction() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "WithLogging_ConfiguresUsingAction" None

    [<Test>]
    member this.ToolSpecificOption_SetsToolOptions() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "ToolSpecificOption_SetsToolOptions" None

    [<Test>]
    member this.InitialOptions_UsesProvidedOptions() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "InitialOptions_UsesProvidedOptions" None

    [<Test>]
    member this.InitialOptions_CanBeModified() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "InitialOptions_CanBeModified" None

    [<Test>]
    member this.FluentChaining_SetsAllOptions() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "FluentChaining_SetsAllOptions" None

    [<Test>]
    member this.FluentChaining_ReturnsSameBuilderInstance() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "FluentChaining_ReturnsSameBuilderInstance" None

    [<Test>]
    member this.ExecuteAsync_CallsCommandExecuteWithOptions() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "ExecuteAsync_CallsCommandExecuteWithOptions" None

    [<Test>]
    member this.ExecuteAsync_PassesCancellationToken() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "ExecuteAsync_PassesCancellationToken" None

    [<Test>]
    member this.ExecuteAsync_PassesExecutionOptions() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "ExecuteAsync_PassesExecutionOptions" None

    [<Test>]
    member this.ToOptions_ReturnsBothOptionsTuple() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "ToOptions_ReturnsBothOptionsTuple" None

    [<Test>]
    member this.ToOptions_CanBeCalledMultipleTimes() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "ToOptions_CanBeCalledMultipleTimes" None

    [<Test>]
    member this.NonGenericInterface_CanBeUsedForChaining() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.CommandBuilderBaseTests> "NonGenericInterface_CanBeUsedForChaining" None
