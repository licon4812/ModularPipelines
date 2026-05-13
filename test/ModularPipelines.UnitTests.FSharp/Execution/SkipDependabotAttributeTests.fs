namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type SkipDependabotAttributeTests() =
    inherit ModularPipelines.UnitTests.Execution.SkipDependabotAttributeTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.SkipDependabotAttributeTests> "Will_Not_Skip_If_Not_Dependabot" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.SkipDependabotAttributeTests> "Will_Skip_If_Dependabot" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.SkipDependabotAttributeTests> "Will_Run_When_Combination_Of_Mandatory_And_Runnable_Run_Category" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.SkipDependabotAttributeTests> "Will__Not_Run_When_Combination_Of_Mandatory_And_Non_Runnable_Run_Category" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.SkipDependabotAttributeTests> "Will_Run_When_Combination_Of_Mandatory_And_Runnable_Run_Category2" 0 None

