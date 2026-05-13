namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ZipTests() =
    inherit ModularPipelines.UnitTests.Helpers.ZipTests()

    [<Test>]
    [<NotInParallel(nameof(ZipTests), Order = 1)>]
    member this.Has_Not_Errored() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.ZipTests> "Has_Not_Errored" None

    [<Test>]
    [<NotInParallel(nameof(ZipTests), Order = 2)>]
    member this.Zip_File_Exists() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.ZipTests> "Zip_File_Exists" None

    [<Test>]
    [<NotInParallel(nameof(ZipTests), Order = 3)>]
    member this.UnZip_Has_Not_Errored() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.ZipTests> "UnZip_Has_Not_Errored" None

    [<Test>]
    [<NotInParallel(nameof(ZipTests), Order = 4)>]
    member this.UnZipped_Folder_Exists() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.ZipTests> "UnZipped_Folder_Exists" None
