namespace ModularPipelines.UnitTests.FSharp.Engine

open ModularPipelines.UnitTests.Engine
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type PipelineRequirementTests() =
    inherit ModularPipelines.UnitTests.Engine.PipelineRequirementTests()

    [<Test>]
    member this.When_Requirement_Succeeds_Then_No_Error() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.PipelineRequirementTests> "When_Requirement_Succeeds_Then_No_Error" None

    [<Test>]
    member this.When_Requirement_Fails_Then_Error() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.PipelineRequirementTests> "When_Requirement_Fails_Then_Error" None

    [<Test>]
    member this.When_Requirement_Fails_With_Reason_Then_Error_With_Reason() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.PipelineRequirementTests> "When_Requirement_Fails_With_Reason_Then_Error_With_Reason" None

    [<Test>]
    member this.MustAsync() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.PipelineRequirementTests> "MustAsync" None

    [<Test>]
    member this.MustAsync() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.PipelineRequirementTests> "MustAsync" None

    [<Test>]
    member this.MustAsync() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.PipelineRequirementTests> "MustAsync" None
