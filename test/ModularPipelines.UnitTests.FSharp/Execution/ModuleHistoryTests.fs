namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleHistoryTests() =
    inherit ModularPipelines.UnitTests.Execution.ModuleHistoryTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Ignore_Category_Without_History_Repository" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Ignore_By_Non_Runnable_Category_Without_History_Repository" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Skip_From_Run_Condition_Without_History_Repository" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Skip_From_Method_Without_History_Repository" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Ignore_Category_With_NotFound_History_Repository" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Ignore_By_Non_Runnable_Category_With_NotFound_History_Repository" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Skip_From_Run_Condition_With_NotFound_History_Repository" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Skip_From_Method_With_NotFound_History_Repository" 0 None

    [<Test>]
    member this.Test_9() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Ignore_Category_With_Good_History_Repository" 0 None

    [<Test>]
    member this.Test_10() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Ignore_By_Non_Runnable_Category_With_Good_History_Repository" 0 None

    [<Test>]
    member this.Test_11() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Skip_From_Run_Condition_With_Good_History_Repository" 0 None

    [<Test>]
    member this.Test_12() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ModuleHistoryTests> "Skip_From_Method_With_Good_History_Repository" 0 None

