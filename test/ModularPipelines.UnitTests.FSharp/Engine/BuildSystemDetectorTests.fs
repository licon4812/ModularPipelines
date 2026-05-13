namespace ModularPipelines.UnitTests.FSharp.Engine

open ModularPipelines.UnitTests.Engine
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type BuildSystemDetectorTests() =
    inherit ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests()

    [<Test>]
    member this.When_No_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_False() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "When_No_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_False" None

    [<Test>]
    member this.When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True_Arguments1() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True" (Some 0)

    [<Test>]
    member this.When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True_Arguments2() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True" (Some 1)

    [<Test>]
    member this.When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True_Arguments3() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True" (Some 2)

    [<Test>]
    member this.When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True_Arguments4() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True" (Some 3)

    [<Test>]
    member this.When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True_Arguments5() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True" (Some 4)

    [<Test>]
    member this.When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True_Arguments6() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True" (Some 5)

    [<Test>]
    member this.When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True_Arguments7() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True" (Some 6)

    [<Test>]
    member this.When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True_Arguments8() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True" (Some 7)

    [<Test>]
    member this.Each_Property_Returns_Result() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "Each_Property_Returns_Result" None

    [<Test>]
    member this.Expected_Build_Agent_Arguments1() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "Expected_Build_Agent" (Some 0)

    [<Test>]
    member this.Expected_Build_Agent_Arguments2() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "Expected_Build_Agent" (Some 1)

    [<Test>]
    member this.Expected_Build_Agent_Arguments3() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "Expected_Build_Agent" (Some 2)

    [<Test>]
    member this.Expected_Build_Agent_Arguments4() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "Expected_Build_Agent" (Some 3)

    [<Test>]
    member this.Expected_Build_Agent_Arguments5() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "Expected_Build_Agent" (Some 4)

    [<Test>]
    member this.Expected_Build_Agent_Arguments6() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "Expected_Build_Agent" (Some 5)

    [<Test>]
    member this.Expected_Build_Agent_Arguments7() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "Expected_Build_Agent" (Some 6)

    [<Test>]
    member this.Expected_Build_Agent_Arguments8() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "Expected_Build_Agent" (Some 7)

    [<Test>]
    member this.Expected_Build_Agent_Arguments9() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "Expected_Build_Agent" (Some 8)
