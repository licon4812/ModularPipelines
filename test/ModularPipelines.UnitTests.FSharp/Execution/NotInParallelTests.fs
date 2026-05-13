namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<TUnit.Core.NotInParallel>]
type NotInParallelTests() =
    inherit ModularPipelines.UnitTests.Execution.NotInParallelTests()

    [<Test>]
    member this.NotInParallel() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.NotInParallelTests> "NotInParallel" None

    [<Test>]
    member this.NotInParallel_With_ParallelDependency() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.NotInParallelTests> "NotInParallel_With_ParallelDependency" None

    [<Test>]
    member this.NotInParallel_With_NonParallelDependency() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.NotInParallelTests> "NotInParallel_With_NonParallelDependency" None
