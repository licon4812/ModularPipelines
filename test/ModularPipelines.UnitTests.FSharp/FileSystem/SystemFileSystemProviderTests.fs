namespace ModularPipelines.UnitTests.FSharp.FileSystem

open ModularPipelines.UnitTests.FileSystem
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type SystemFileSystemProviderTests() =
    inherit ModularPipelines.UnitTests.FileSystem.SystemFileSystemProviderTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.SystemFileSystemProviderTests> "ReadAllTextAsync_ReadsFileContents" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.SystemFileSystemProviderTests> "WriteAllTextAsync_WritesFileContents" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.SystemFileSystemProviderTests> "FileExists_ReturnsTrueForExistingFile" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.SystemFileSystemProviderTests> "FileExists_ReturnsFalseForNonExistingFile" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.SystemFileSystemProviderTests> "CreateDirectory_CreatesNewDirectory" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.SystemFileSystemProviderTests> "DeleteDirectory_RemovesDirectoryRecursively" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.SystemFileSystemProviderTests> "Combine_JoinsPaths" 0 None

