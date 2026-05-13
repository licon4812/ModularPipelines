namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type RunnableCategoryTests() =
    inherit ModularPipelines.UnitTests.Execution.RunnableCategoryTests()

    [<Test>]
    member this.When_RunCategories_Specified_Then_Expected_Modules_Run() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.RunnableCategoryTests> "When_RunCategories_Specified_Then_Expected_Modules_Run" None

    [<Test>]
    member this.When_IgnoreCategories_Specified_Then_Expected_Modules_Run() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.RunnableCategoryTests> "When_IgnoreCategories_Specified_Then_Expected_Modules_Run" None
