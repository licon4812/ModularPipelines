namespace ModularPipelines.UnitTests.FSharp.FileSystem

open ModularPipelines.UnitTests.FileSystem
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type FolderProviderTests() =
    inherit ModularPipelines.UnitTests.FileSystem.FolderProviderTests()

    [<Test>]
    member this.Create_UsesProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderProviderTests> "Create_UsesProvider" None

    [<Test>]
    member this.Delete_UsesProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderProviderTests> "Delete_UsesProvider" None

    [<Test>]
    member this.GetFile_ReturnsFileWithSameProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderProviderTests> "GetFile_ReturnsFileWithSameProvider" None

    [<Test>]
    member this.GetFolder_ReturnsSubfolderWithSameProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderProviderTests> "GetFolder_ReturnsSubfolderWithSameProvider" None

    [<Test>]
    member this.MoveTo_ReturnsNewFolderWithProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderProviderTests> "MoveTo_ReturnsNewFolderWithProvider" None

    [<Test>]
    member this.DefaultConstructor_UsesSystemProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderProviderTests> "DefaultConstructor_UsesSystemProvider" None

    [<Test>]
    member this.CreateAsync_UsesProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderProviderTests> "CreateAsync_UsesProvider" None

    [<Test>]
    member this.DeleteAsync_UsesProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderProviderTests> "DeleteAsync_UsesProvider" None

    [<Test>]
    member this.MoveToAsync_ReturnsNewFolderWithProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderProviderTests> "MoveToAsync_ReturnsNewFolderWithProvider" None

    [<Test>]
    member this.CreateFolder_UsesProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderProviderTests> "CreateFolder_UsesProvider" None

    [<Test>]
    member this.CreateFile_UsesProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderProviderTests> "CreateFile_UsesProvider" None

    [<Test>]
    member this.CopyTo_UsesProviderAndReturnsFolderWithProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderProviderTests> "CopyTo_UsesProviderAndReturnsFolderWithProvider" None

    [<Test>]
    member this.CopyToAsync_UsesProviderAndReturnsFolderWithProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderProviderTests> "CopyToAsync_UsesProviderAndReturnsFolderWithProvider" None
