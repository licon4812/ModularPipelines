namespace ModularPipelines.UnitTests.FSharp.Builders

open ModularPipelines.UnitTests.Builders
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DotNetBuildBuilderTests() =
    inherit ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "ForProject_SetsProjectPath" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithConfiguration_SetsConfiguration" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithFramework_SetsFramework" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithRuntime_SetsRuntime" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithOutput_SetsOutput" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithNoRestore_EnablesNoRestore" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithNoIncremental_EnablesNoIncremental" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithNoLogo_EnablesNoLogo" 0 None

    [<Test>]
    member this.Test_9() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithProperty_AddsProperty" 0 None

    [<Test>]
    member this.Test_10() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithProperty_AddsMultipleProperties" 0 None

    [<Test>]
    member this.Test_11() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithWorkingDirectory_SetsWorkingDirectory" 0 None

    [<Test>]
    member this.Test_12() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithTimeout_SetsTimeout" 0 None

    [<Test>]
    member this.Test_13() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithEnvironmentVariable_AddsVariable" 0 None

    [<Test>]
    member this.Test_14() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "WithThrowOnError_SetsThrowOnError" 0 None

    [<Test>]
    member this.Test_15() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "FluentChaining_SetsAllOptions" 0 None

    [<Test>]
    member this.Test_16() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "FluentChaining_ReturnsSameBuilderInstance" 0 None

    [<Test>]
    member this.Test_17() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "ExecuteAsync_CallsCommandExecuteWithOptions" 0 None

    [<Test>]
    member this.Test_18() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "ExecuteAsync_PassesExecutionOptions" 0 None

    [<Test>]
    member this.Test_19() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "InitialOptions_UsesProvidedOptions" 0 None

    [<Test>]
    member this.Test_20() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Builders.DotNetBuildBuilderTests> "InitialOptions_CanBeOverridden" 0 None

