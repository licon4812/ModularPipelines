namespace ModularPipelines.UnitTests.FSharp.Engine

open ModularPipelines.UnitTests.Engine
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<TUnit.Core.NotInParallel(nameof(MetricsCollectorTests))>]
type MetricsCollectorTests() =
    inherit ModularPipelines.UnitTests.Engine.MetricsCollectorTests()

    [<Test>]
    member this.PipelineSummary_ContainsMetrics() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.MetricsCollectorTests> "PipelineSummary_ContainsMetrics" None

    [<Test>]
    member this.PipelineMetrics_HasParallelismFactor() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.MetricsCollectorTests> "PipelineMetrics_HasParallelismFactor" None

    [<Test>]
    member this.PipelineMetrics_HasPeakConcurrency() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.MetricsCollectorTests> "PipelineMetrics_HasPeakConcurrency" None

    [<Test>]
    member this.PipelineMetrics_HasAverageConcurrency() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.MetricsCollectorTests> "PipelineMetrics_HasAverageConcurrency" None

    [<Test>]
    member this.PipelineMetrics_HasEfficiency() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.MetricsCollectorTests> "PipelineMetrics_HasEfficiency" None

    [<Test>]
    member this.PipelineMetrics_HasModuleCounts() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.MetricsCollectorTests> "PipelineMetrics_HasModuleCounts" None

    [<Test>]
    member this.PipelineMetrics_HasTimingData() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.MetricsCollectorTests> "PipelineMetrics_HasTimingData" None

    [<Test>]
    member this.PipelineSummary_ContainsModuleTimelines() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.MetricsCollectorTests> "PipelineSummary_ContainsModuleTimelines" None

    [<Test>]
    member this.ModuleTimeline_ContainsModuleName() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.MetricsCollectorTests> "ModuleTimeline_ContainsModuleName" None

    [<Test>]
    member this.ModuleTimeline_ContainsTimingData() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.MetricsCollectorTests> "ModuleTimeline_ContainsTimingData" None
