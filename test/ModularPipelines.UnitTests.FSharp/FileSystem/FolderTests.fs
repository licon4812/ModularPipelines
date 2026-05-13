namespace ModularPipelines.UnitTests.FSharp.FileSystem

open ModularPipelines.UnitTests.FileSystem
open ModularPipelines.UnitTests.FSharp
open ModularPipelines.UnitTests.Attributes
open TUnit.Core

type FolderTests() =
    inherit ModularPipelines.UnitTests.FileSystem.FolderTests()

    [<Test>]
    member this.CleanFiles() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "CleanFiles" None

    [<Test>]
    member this.CleanFolders() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "CleanFolders" None

    [<Test>]
    member this.FindFile() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "FindFile" None

    [<Test>]
    member this.FindFileLogs() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "FindFileLogs" None

    [<Test>]
    member this.FindFolder() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "FindFolder" None

    [<Test>]
    member this.Delete() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "Delete" None

    [<Test>]
    member this.MoveTo() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "MoveTo" None

    [<Test>]
    member this.CopyTo() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "CopyTo" None

    [<Test>]
    member this.Data_Is_Populated() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "Data_Is_Populated" None

    [<Test>]
    member this.CreateFolder() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "CreateFolder" None

    [<Test>]
    member this.CreateFile() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "CreateFile" None

    [<Test>]
    member this.CreateSubfolder() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "CreateSubfolder" None

    [<Test>]
    member this.Null_FileInfo_Implicit_Cast() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "Null_FileInfo_Implicit_Cast" None

    [<Test>]
    member this.Null_String_Implicit_Cast() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "Null_String_Implicit_Cast" None

    [<Test>]
    member this.FileInfo_Implicit_Cast() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "FileInfo_Implicit_Cast" None

    [<Test>]
    member this.String_Implicit_Cast() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "String_Implicit_Cast" None

    [<Test>]
    [<WindowsOnlyTest>]
    member this.Attributes() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "Attributes" None

    [<Test>]
    member this.EqualityTrue() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "EqualityTrue" None

    [<Test>]
    member this.EqualityFalse() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "EqualityFalse" None

    [<Test>]
    member this.AssertExists() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "AssertExists" None

    [<Test>]
    member this.AssertExists_ThrowsWhenNotExists() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "AssertExists_ThrowsWhenNotExists" None

    [<Test>]
    member this.AssertExists_ThrowsWhenNull() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "AssertExists_ThrowsWhenNull" None

    [<Test>]
    member this.Searching_Files_With_Nested_Folders_Does_Not_Throw() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "Searching_Files_With_Nested_Folders_Does_Not_Throw" None

    [<Test>]
    member this.GetFiles_With_Pattern_Does_Not_Throw() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "GetFiles_With_Pattern_Does_Not_Throw" None

    [<Test>]
    member this.Searching_Folders_With_Nested_Structure_Does_Not_Throw() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "Searching_Folders_With_Nested_Structure_Does_Not_Throw" None
