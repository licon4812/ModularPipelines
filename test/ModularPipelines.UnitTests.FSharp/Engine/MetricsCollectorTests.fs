namespace ModularPipelines.UnitTests.FSharp.Engine

open ModularPipelines.UnitTests.Engine
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<TUnit.Core.NotInParallel(nameof(MetricsCollectorTests))>]
type MetricsCollectorTests() =
    inherit ModularPipelines.UnitTests.Engine.MetricsCollectorTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.MetricsCollectorTests> "PipelineSummary_ContainsMetrics" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.MetricsCollectorTests> "PipelineMetrics_HasParallelismFactor" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.MetricsCollectorTests> "PipelineMetrics_HasPeakConcurrency" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.MetricsCollectorTests> "PipelineMetrics_HasAverageConcurrency" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.MetricsCollectorTests> "PipelineMetrics_HasEfficiency" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.MetricsCollectorTests> "PipelineMetrics_HasModuleCounts" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.MetricsCollectorTests> "PipelineMetrics_HasTimingData" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.MetricsCollectorTests> "PipelineSummary_ContainsModuleTimelines" 0 None

    [<Test>]
    member this.Test_9() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.MetricsCollectorTests> "ModuleTimeline_ContainsModuleName" 0 None

    [<Test>]
    member this.Test_10() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.MetricsCollectorTests> "ModuleTimeline_ContainsTimingData" 0 None

