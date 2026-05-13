namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<Skip("FTP tests flaky due to server load")>]
type FtpTests() =
    inherit ModularPipelines.UnitTests.Helpers.FtpTests()

    [<Test>]
    [<NotInParallel(nameof(FtpTests), Order = 1)>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.FtpTests> "Can_Download" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.FtpTests> "Client_Is_Disposed_Properly" 0 None

