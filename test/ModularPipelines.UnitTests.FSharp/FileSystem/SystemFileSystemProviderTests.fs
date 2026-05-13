namespace ModularPipelines.UnitTests.FSharp.FileSystem

open ModularPipelines.UnitTests.FileSystem
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type SystemFileSystemProviderTests() =
    inherit ModularPipelines.UnitTests.FileSystem.SystemFileSystemProviderTests()

    [<Test>]
    member this.ReadAllTextAsync_ReadsFileContents() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.SystemFileSystemProviderTests> "ReadAllTextAsync_ReadsFileContents" None

    [<Test>]
    member this.WriteAllTextAsync_WritesFileContents() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.SystemFileSystemProviderTests> "WriteAllTextAsync_WritesFileContents" None

    [<Test>]
    member this.FileExists_ReturnsTrueForExistingFile() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.SystemFileSystemProviderTests> "FileExists_ReturnsTrueForExistingFile" None

    [<Test>]
    member this.FileExists_ReturnsFalseForNonExistingFile() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.SystemFileSystemProviderTests> "FileExists_ReturnsFalseForNonExistingFile" None

    [<Test>]
    member this.CreateDirectory_CreatesNewDirectory() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.SystemFileSystemProviderTests> "CreateDirectory_CreatesNewDirectory" None

    [<Test>]
    member this.DeleteDirectory_RemovesDirectoryRecursively() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.SystemFileSystemProviderTests> "DeleteDirectory_RemovesDirectoryRecursively" None

    [<Test>]
    member this.Combine_JoinsPaths() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.SystemFileSystemProviderTests> "Combine_JoinsPaths" None
