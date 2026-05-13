namespace ModularPipelines.UnitTests.FSharp.Engine

open ModularPipelines.UnitTests.Engine
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<TUnit.Core.NotInParallel>]
type PipelineProgressTests() =
    inherit ModularPipelines.UnitTests.Engine.PipelineProgressTests()

    [<Test>]
    [<Retry(5)>]
    member this.Can_Show_Progress() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.PipelineProgressTests> "Can_Show_Progress" None
