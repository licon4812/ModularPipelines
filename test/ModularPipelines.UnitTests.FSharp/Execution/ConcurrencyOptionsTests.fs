namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<TUnit.Core.NotInParallel(nameof(ConcurrencyOptionsTests))>]
type ConcurrencyOptionsTests() =
    inherit ModularPipelines.UnitTests.Execution.ConcurrencyOptionsTests()

    [<Test>]
    member this.ConcurrencyOptions_HasCorrectDefaultValues() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ConcurrencyOptionsTests> "ConcurrencyOptions_HasCorrectDefaultValues" None

    [<Test>]
    member this.Pipeline_RespectsMaxParallelismSetting() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ConcurrencyOptionsTests> "Pipeline_RespectsMaxParallelismSetting" None

    [<Test>]
    member this.Pipeline_RespectsMaxCpuIntensiveModulesSetting() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ConcurrencyOptionsTests> "Pipeline_RespectsMaxCpuIntensiveModulesSetting" None

    [<Test>]
    member this.Pipeline_RespectsMaxIoIntensiveModulesSetting() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ConcurrencyOptionsTests> "Pipeline_RespectsMaxIoIntensiveModulesSetting" None

    [<Test>]
    member this.PipelineOptions_HasConcurrencyProperty() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.ConcurrencyOptionsTests> "PipelineOptions_HasConcurrencyProperty" None
