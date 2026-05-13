namespace ModularPipelines.UnitTests.FSharp.Engine

open ModularPipelines.UnitTests.Engine
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type PipelineRequirementTests() =
    inherit ModularPipelines.UnitTests.Engine.PipelineRequirementTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.PipelineRequirementTests> "When_Requirement_Succeeds_Then_No_Error" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.PipelineRequirementTests> "When_Requirement_Fails_Then_Error" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.PipelineRequirementTests> "When_Requirement_Fails_With_Reason_Then_Error_With_Reason" 0 None

