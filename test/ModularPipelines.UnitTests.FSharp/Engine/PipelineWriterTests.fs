namespace ModularPipelines.UnitTests.FSharp.Engine

open ModularPipelines.UnitTests.Engine
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type PipelineWriterTests() =
    inherit ModularPipelines.UnitTests.Engine.PipelineWriterTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.PipelineWriterTests> "GitHubWriter" 0 None

