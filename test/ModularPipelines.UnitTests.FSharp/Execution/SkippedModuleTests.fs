namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type SkippedModuleTests() =
    inherit ModularPipelines.UnitTests.Execution.SkippedModuleTests()

    [<Test>]
    member this.Skipped_Result_Is_As_Expected() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.SkippedModuleTests> "Skipped_Result_Is_As_Expected" None
