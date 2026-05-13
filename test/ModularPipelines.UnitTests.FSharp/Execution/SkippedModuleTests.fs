namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type SkippedModuleTests() =
    inherit ModularPipelines.UnitTests.Execution.SkippedModuleTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.SkippedModuleTests> "Skipped_Result_Is_As_Expected" 0 None

