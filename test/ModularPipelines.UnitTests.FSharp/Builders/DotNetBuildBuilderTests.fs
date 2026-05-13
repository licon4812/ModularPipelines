namespace ModularPipelines.UnitTests.FSharp.Builders

open ModularPipelines.UnitTests.Builders
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DotNetBuildBuilderTests() =
    inherit ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests()

    [<Test>]
    member this.ForProject_SetsProjectPath() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "ForProject_SetsProjectPath" None

    [<Test>]
    member this.WithConfiguration_SetsConfiguration() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithConfiguration_SetsConfiguration" None

    [<Test>]
    member this.WithFramework_SetsFramework() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithFramework_SetsFramework" None

    [<Test>]
    member this.WithRuntime_SetsRuntime() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithRuntime_SetsRuntime" None

    [<Test>]
    member this.WithOutput_SetsOutput() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithOutput_SetsOutput" None

    [<Test>]
    member this.WithNoRestore_EnablesNoRestore() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithNoRestore_EnablesNoRestore" None

    [<Test>]
    member this.WithNoIncremental_EnablesNoIncremental() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithNoIncremental_EnablesNoIncremental" None

    [<Test>]
    member this.WithNoLogo_EnablesNoLogo() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithNoLogo_EnablesNoLogo" None

    [<Test>]
    member this.WithProperty_AddsProperty() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithProperty_AddsProperty" None

    [<Test>]
    member this.WithProperty_AddsMultipleProperties() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithProperty_AddsMultipleProperties" None

    [<Test>]
    member this.WithWorkingDirectory_SetsWorkingDirectory() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithWorkingDirectory_SetsWorkingDirectory" None

    [<Test>]
    member this.WithTimeout_SetsTimeout() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithTimeout_SetsTimeout" None

    [<Test>]
    member this.WithEnvironmentVariable_AddsVariable() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithEnvironmentVariable_AddsVariable" None

    [<Test>]
    member this.WithThrowOnError_SetsThrowOnError() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithThrowOnError_SetsThrowOnError" None

    [<Test>]
    member this.FluentChaining_SetsAllOptions() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "FluentChaining_SetsAllOptions" None

    [<Test>]
    member this.FluentChaining_ReturnsSameBuilderInstance() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "FluentChaining_ReturnsSameBuilderInstance" None

    [<Test>]
    member this.ExecuteAsync_CallsCommandExecuteWithOptions() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "ExecuteAsync_CallsCommandExecuteWithOptions" None

    [<Test>]
    member this.ExecuteAsync_PassesExecutionOptions() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "ExecuteAsync_PassesExecutionOptions" None

    [<Test>]
    member this.InitialOptions_UsesProvidedOptions() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "InitialOptions_UsesProvidedOptions" None

    [<Test>]
    member this.InitialOptions_CanBeOverridden() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "InitialOptions_CanBeOverridden" None
