namespace ModularPipelines.UnitTests.FSharp.Engine

open ModularPipelines.UnitTests.Engine
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DisposerTests() =
    inherit ModularPipelines.UnitTests.Engine.DisposerTests()

    [<Test>]
    member this.Disposer_Calls_Async() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.DisposerTests> "Disposer_Calls_Async" None

    [<Test>]
    member this.Disposer_Calls_Sync() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.DisposerTests> "Disposer_Calls_Sync" None
