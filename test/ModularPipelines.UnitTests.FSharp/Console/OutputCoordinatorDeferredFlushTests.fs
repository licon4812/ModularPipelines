namespace ModularPipelines.UnitTests.FSharp.Console

open ModularPipelines.UnitTests.Console
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type OutputCoordinatorDeferredFlushTests() =
    inherit ModularPipelines.UnitTests.Console.OutputCoordinatorDeferredFlushTests()

    [<Test>]
    member this.Pipeline_Completes_When_Progress_Disabled() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Console.OutputCoordinatorDeferredFlushTests> "Pipeline_Completes_When_Progress_Disabled" None

    [<Test>]
    member this.Pipeline_With_Multiple_Modules_Completes_Successfully() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Console.OutputCoordinatorDeferredFlushTests> "Pipeline_With_Multiple_Modules_Completes_Successfully" None
