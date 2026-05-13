namespace ModularPipelines.UnitTests.FSharp.Engine

open ModularPipelines.UnitTests.Engine
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type SafeEstimatedTimeProviderTests() =
    inherit ModularPipelines.UnitTests.Engine.SafeEstimatedTimeProviderTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.SafeEstimatedTimeProviderTests> "When_EstimatedTimeProvider_Succeeds_Then_No_Error" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.SafeEstimatedTimeProviderTests> "When_EstimatedTimeProvider_Fails_Receiving_Time_Then_Still_No_Error" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.SafeEstimatedTimeProviderTests> "When_EstimatedTimeProvider_Fails_Saving_Time_Then_Still_No_Error" 0 None

