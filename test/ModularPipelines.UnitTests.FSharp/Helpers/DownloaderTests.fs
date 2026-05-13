namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DownloaderTests() =
    inherit ModularPipelines.UnitTests.Helpers.DownloaderTests()

    [<Test>]
    [<Retry(3)>]
    member this.Can_Download() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.DownloaderTests> "Can_Download" None
