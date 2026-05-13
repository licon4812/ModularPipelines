namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ZipTests() =
    inherit ModularPipelines.UnitTests.Helpers.ZipTests()

    [<Test>]
    [<NotInParallel(nameof(ZipTests), Order = 1)>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.ZipTests> "Has_Not_Errored" 0 None

    [<Test>]
    [<NotInParallel(nameof(ZipTests), Order = 2)>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.ZipTests> "Zip_File_Exists" 0 None

    [<Test>]
    [<NotInParallel(nameof(ZipTests), Order = 3)>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.ZipTests> "UnZip_Has_Not_Errored" 0 None

    [<Test>]
    [<NotInParallel(nameof(ZipTests), Order = 4)>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.ZipTests> "UnZipped_Folder_Exists" 0 None

