namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<TUnit.Core.NotInParallel(nameof(EngineCancellationTokenTests))>]
type EngineCancellationTokenTests() =
    inherit ModularPipelines.UnitTests.Execution.EngineCancellationTokenTests()

    [<Test>]
    member this.When_Cancel_Engine_Token_With_DependsOn_Then_Modules_Cancel() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.EngineCancellationTokenTests> "When_Cancel_Engine_Token_With_DependsOn_Then_Modules_Cancel" None

    [<Test>]
    member this.When_Cancel_Engine_Token_Without_DependsOn_Then_Modules_Cancel() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.EngineCancellationTokenTests> "When_Cancel_Engine_Token_Without_DependsOn_Then_Modules_Cancel" None

    [<Test>]
    member this.When_Cancel_Engine_Token_Without_DependsOn_Then_Modules_Cancel_Without_Cancellation() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.EngineCancellationTokenTests> "When_Cancel_Engine_Token_Without_DependsOn_Then_Modules_Cancel_Without_Cancellation" None
