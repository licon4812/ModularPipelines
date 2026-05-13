namespace ModularPipelines.UnitTests.FSharp.Engine

open ModularPipelines.UnitTests.Engine
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type UnusedModuleDetectorTests() =
    inherit ModularPipelines.UnitTests.Engine.UnusedModuleDetectorTests()

    [<Test>]
    member this.Logs_Unregisted_Modules_Correctly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.UnusedModuleDetectorTests> "Logs_Unregisted_Modules_Correctly" None
