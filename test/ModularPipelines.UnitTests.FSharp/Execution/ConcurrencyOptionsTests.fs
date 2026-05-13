namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<TUnit.Core.NotInParallel(nameof(ConcurrencyOptionsTests))>]
type ConcurrencyOptionsTests() =
    inherit ModularPipelines.UnitTests.Execution.ConcurrencyOptionsTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ConcurrencyOptionsTests> "ConcurrencyOptions_HasCorrectDefaultValues" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ConcurrencyOptionsTests> "Pipeline_RespectsMaxParallelismSetting" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ConcurrencyOptionsTests> "Pipeline_RespectsMaxCpuIntensiveModulesSetting" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ConcurrencyOptionsTests> "Pipeline_RespectsMaxIoIntensiveModulesSetting" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.ConcurrencyOptionsTests> "PipelineOptions_HasConcurrencyProperty" 0 None

