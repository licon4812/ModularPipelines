namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ChecksumTests() =
    inherit ModularPipelines.UnitTests.Helpers.ChecksumTests()

    [<Test>]
    member this.Md5_Checksum() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.ChecksumTests> "Md5_Checksum" None
