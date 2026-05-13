namespace ModularPipelines.UnitTests.FSharp.Engine

open ModularPipelines.UnitTests.Engine
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type SafeEstimatedTimeProviderTests() =
    inherit ModularPipelines.UnitTests.Engine.SafeEstimatedTimeProviderTests()

    [<Test>]
    member this.When_EstimatedTimeProvider_Succeeds_Then_No_Error() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.SafeEstimatedTimeProviderTests> "When_EstimatedTimeProvider_Succeeds_Then_No_Error" None

    [<Test>]
    member this.When_EstimatedTimeProvider_Fails_Receiving_Time_Then_Still_No_Error() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.SafeEstimatedTimeProviderTests> "When_EstimatedTimeProvider_Fails_Receiving_Time_Then_Still_No_Error" None

    [<Test>]
    member this.When_EstimatedTimeProvider_Fails_Saving_Time_Then_Still_No_Error() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.SafeEstimatedTimeProviderTests> "When_EstimatedTimeProvider_Fails_Saving_Time_Then_Still_No_Error" None

    [<Test>]
    member this.GetModuleEstimatedTimeAsync() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.SafeEstimatedTimeProviderTests> "GetModuleEstimatedTimeAsync" None

    [<Test>]
    member this.SaveModuleTimeAsync() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.SafeEstimatedTimeProviderTests> "SaveModuleTimeAsync" None

    [<Test>]
    member this.SaveSubModuleTimeAsync() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.SafeEstimatedTimeProviderTests> "SaveSubModuleTimeAsync" None

    [<Test>]
    member this.GetModuleEstimatedTimeAsync() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.SafeEstimatedTimeProviderTests> "GetModuleEstimatedTimeAsync" None

    [<Test>]
    member this.SaveModuleTimeAsync() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.SafeEstimatedTimeProviderTests> "SaveModuleTimeAsync" None

    [<Test>]
    member this.SaveSubModuleTimeAsync() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.SafeEstimatedTimeProviderTests> "SaveSubModuleTimeAsync" None

    [<Test>]
    member this.GetModuleEstimatedTimeAsync() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.SafeEstimatedTimeProviderTests> "GetModuleEstimatedTimeAsync" None

    [<Test>]
    member this.SaveModuleTimeAsync() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.SafeEstimatedTimeProviderTests> "SaveModuleTimeAsync" None

    [<Test>]
    member this.SaveSubModuleTimeAsync() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.SafeEstimatedTimeProviderTests> "SaveSubModuleTimeAsync" None
