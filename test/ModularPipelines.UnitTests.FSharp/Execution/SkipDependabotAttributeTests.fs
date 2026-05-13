namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type SkipDependabotAttributeTests() =
    inherit ModularPipelines.UnitTests.Execution.SkipDependabotAttributeTests()

    [<Test>]
    member this.Will_Not_Skip_If_Not_Dependabot() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.SkipDependabotAttributeTests> "Will_Not_Skip_If_Not_Dependabot" None

    [<Test>]
    member this.Will_Skip_If_Dependabot() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.SkipDependabotAttributeTests> "Will_Skip_If_Dependabot" None

    [<Test>]
    member this.Will_Run_When_Combination_Of_Mandatory_And_Runnable_Run_Category() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.SkipDependabotAttributeTests> "Will_Run_When_Combination_Of_Mandatory_And_Runnable_Run_Category" None

    [<Test>]
    member this.Will__Not_Run_When_Combination_Of_Mandatory_And_Non_Runnable_Run_Category() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.SkipDependabotAttributeTests> "Will__Not_Run_When_Combination_Of_Mandatory_And_Non_Runnable_Run_Category" None

    [<Test>]
    member this.Will_Run_When_Combination_Of_Mandatory_And_Runnable_Run_Category2() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.SkipDependabotAttributeTests> "Will_Run_When_Combination_Of_Mandatory_And_Runnable_Run_Category2" None
