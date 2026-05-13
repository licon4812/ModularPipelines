namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DownloaderTests() =
    inherit ModularPipelines.UnitTests.Helpers.DownloaderTests()

    [<Test>]
    [<Retry(3)>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.DownloaderTests> "Can_Download" 0 None

