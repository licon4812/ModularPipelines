namespace ModularPipelines.UnitTests.FSharp.Engine

open ModularPipelines.UnitTests.Engine
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type PipelineWriterTests() =
    inherit ModularPipelines.UnitTests.Engine.PipelineWriterTests()

    [<Test>]
    member this.GitHubWriter() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.PipelineWriterTests> "GitHubWriter" None
