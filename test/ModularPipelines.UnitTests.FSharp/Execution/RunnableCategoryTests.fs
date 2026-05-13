namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type RunnableCategoryTests() =
    inherit ModularPipelines.UnitTests.Execution.RunnableCategoryTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.RunnableCategoryTests> "When_RunCategories_Specified_Then_Expected_Modules_Run" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.RunnableCategoryTests> "When_IgnoreCategories_Specified_Then_Expected_Modules_Run" 0 None

