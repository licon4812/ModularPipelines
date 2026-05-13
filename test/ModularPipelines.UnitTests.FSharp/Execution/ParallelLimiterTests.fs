namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ParallelLimiterTests() =
    inherit ModularPipelines.UnitTests.Execution.ParallelLimiterTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ParallelLimiterTests> "LimitParallel" 0 None

