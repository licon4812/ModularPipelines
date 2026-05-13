namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ParallelLimiterTests() =
    inherit ModularPipelines.UnitTests.Execution.ParallelLimiterTests()

    [<Test>]
    member this.LimitParallel() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ParallelLimiterTests> "LimitParallel" None
