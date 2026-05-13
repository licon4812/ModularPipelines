namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleHistoryTests() =
    inherit ModularPipelines.UnitTests.Execution.ModuleHistoryTests()

    [<Test>]
    member this.Ignore_Category_Without_History_Repository() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Ignore_Category_Without_History_Repository" None

    [<Test>]
    member this.Ignore_By_Non_Runnable_Category_Without_History_Repository() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Ignore_By_Non_Runnable_Category_Without_History_Repository" None

    [<Test>]
    member this.Skip_From_Run_Condition_Without_History_Repository() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Skip_From_Run_Condition_Without_History_Repository" None

    [<Test>]
    member this.Skip_From_Method_Without_History_Repository() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Skip_From_Method_Without_History_Repository" None

    [<Test>]
    member this.Ignore_Category_With_NotFound_History_Repository() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Ignore_Category_With_NotFound_History_Repository" None

    [<Test>]
    member this.Ignore_By_Non_Runnable_Category_With_NotFound_History_Repository() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Ignore_By_Non_Runnable_Category_With_NotFound_History_Repository" None

    [<Test>]
    member this.Skip_From_Run_Condition_With_NotFound_History_Repository() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Skip_From_Run_Condition_With_NotFound_History_Repository" None

    [<Test>]
    member this.Skip_From_Method_With_NotFound_History_Repository() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Skip_From_Method_With_NotFound_History_Repository" None

    [<Test>]
    member this.Ignore_Category_With_Good_History_Repository() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Ignore_Category_With_Good_History_Repository" None

    [<Test>]
    member this.Ignore_By_Non_Runnable_Category_With_Good_History_Repository() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Ignore_By_Non_Runnable_Category_With_Good_History_Repository" None

    [<Test>]
    member this.Skip_From_Run_Condition_With_Good_History_Repository() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Skip_From_Run_Condition_With_Good_History_Repository" None

    [<Test>]
    member this.Skip_From_Method_With_Good_History_Repository() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Skip_From_Method_With_Good_History_Repository" None
