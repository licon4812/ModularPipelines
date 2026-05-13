namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<Skip("FTP tests flaky due to server load")>]
type FtpTests() =
    inherit ModularPipelines.UnitTests.Helpers.FtpTests()

    [<Test>]
    [<NotInParallel(nameof(FtpTests), Order = 1)>]
    member this.Can_Download() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.FtpTests> "Can_Download" None

    [<Test>]
    member this.Client_Is_Disposed_Properly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.FtpTests> "Client_Is_Disposed_Properly" None
