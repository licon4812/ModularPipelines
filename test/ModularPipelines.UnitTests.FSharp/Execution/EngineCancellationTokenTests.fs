namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<TUnit.Core.NotInParallel(nameof(EngineCancellationTokenTests))>]
type EngineCancellationTokenTests() =
    inherit ModularPipelines.UnitTests.Execution.EngineCancellationTokenTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.EngineCancellationTokenTests> "When_Cancel_Engine_Token_With_DependsOn_Then_Modules_Cancel" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.EngineCancellationTokenTests> "When_Cancel_Engine_Token_Without_DependsOn_Then_Modules_Cancel" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Execution.EngineCancellationTokenTests> "When_Cancel_Engine_Token_Without_DependsOn_Then_Modules_Cancel_Without_Cancellation" 0 None

