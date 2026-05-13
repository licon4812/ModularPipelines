namespace ModularPipelines.UnitTests.FSharp.Console

open ModularPipelines.UnitTests.Console
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type OutputCoordinatorDeferredFlushTests() =
    inherit ModularPipelines.UnitTests.Console.OutputCoordinatorDeferredFlushTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Console.OutputCoordinatorDeferredFlushTests> "Pipeline_Completes_When_Progress_Disabled" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Console.OutputCoordinatorDeferredFlushTests> "Pipeline_With_Multiple_Modules_Completes_Successfully" 0 None

