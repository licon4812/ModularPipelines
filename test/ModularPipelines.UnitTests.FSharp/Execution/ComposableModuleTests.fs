namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ComposableModuleTests() =
    inherit ModularPipelines.UnitTests.Execution.ComposableModuleTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ComposableModuleTests> "Skippable_Module_Is_Skipped_When_Condition_True" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ComposableModuleTests> "Skippable_Module_Executes_When_Condition_False" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ComposableModuleTests> "Timeoutable_Module_Has_Custom_Timeout" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ComposableModuleTests> "Multi_Behavior_Module_Calls_Hooks" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ComposableModuleTests> "AlwaysRun_Module_Has_Correct_Configuration" 0 None

