namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ComposableModuleTests() =
    inherit ModularPipelines.UnitTests.Execution.ComposableModuleTests()

    [<Test>]
    member this.Skippable_Module_Is_Skipped_When_Condition_True() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ComposableModuleTests> "Skippable_Module_Is_Skipped_When_Condition_True" None

    [<Test>]
    member this.Skippable_Module_Executes_When_Condition_False() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ComposableModuleTests> "Skippable_Module_Executes_When_Condition_False" None

    [<Test>]
    member this.Timeoutable_Module_Has_Custom_Timeout() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ComposableModuleTests> "Timeoutable_Module_Has_Custom_Timeout" None

    [<Test>]
    member this.Multi_Behavior_Module_Calls_Hooks() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ComposableModuleTests> "Multi_Behavior_Module_Calls_Hooks" None

    [<Test>]
    member this.AlwaysRun_Module_Has_Correct_Configuration() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ComposableModuleTests> "AlwaysRun_Module_Has_Correct_Configuration" None
