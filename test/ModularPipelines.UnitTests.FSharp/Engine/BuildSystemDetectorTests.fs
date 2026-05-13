namespace ModularPipelines.UnitTests.FSharp.Engine

open ModularPipelines.UnitTests.Engine
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type BuildSystemDetectorTests() =
    inherit ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "When_No_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_False" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True" 0 (Some 0)

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True" 0 (Some 1)

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True" 0 (Some 2)

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True" 0 (Some 3)

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True" 0 (Some 4)

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True" 0 (Some 5)

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True" 0 (Some 6)

    [<Test>]
    member this.Test_9() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True" 0 (Some 7)

    [<Test>]
    member this.Test_10() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "Each_Property_Returns_Result" 0 None

    [<Test>]
    member this.Test_11() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "Expected_Build_Agent" 0 (Some 0)

    [<Test>]
    member this.Test_12() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "Expected_Build_Agent" 0 (Some 1)

    [<Test>]
    member this.Test_13() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "Expected_Build_Agent" 0 (Some 2)

    [<Test>]
    member this.Test_14() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "Expected_Build_Agent" 0 (Some 3)

    [<Test>]
    member this.Test_15() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "Expected_Build_Agent" 0 (Some 4)

    [<Test>]
    member this.Test_16() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "Expected_Build_Agent" 0 (Some 5)

    [<Test>]
    member this.Test_17() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "Expected_Build_Agent" 0 (Some 6)

    [<Test>]
    member this.Test_18() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "Expected_Build_Agent" 0 (Some 7)

    [<Test>]
    member this.Test_19() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.BuildSystemDetectorTests> "Expected_Build_Agent" 0 (Some 8)

