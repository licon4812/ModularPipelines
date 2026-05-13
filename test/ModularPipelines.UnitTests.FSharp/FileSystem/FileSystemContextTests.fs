namespace ModularPipelines.UnitTests.FSharp.FileSystem

open ModularPipelines.UnitTests.FileSystem
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type FileSystemContextTests() =
    inherit ModularPipelines.UnitTests.FileSystem.FileSystemContextTests()

    [<Test>]
    member this.Move_File() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileSystemContextTests> "Move_File" None

    [<Test>]
    member this.Copy_File() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileSystemContextTests> "Copy_File" None

    [<Test>]
    member this.File_Delete() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileSystemContextTests> "File_Delete" None

    [<Test>]
    member this.File_Data_Populated() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileSystemContextTests> "File_Data_Populated" None

    [<Test>]
    member this.Move_Folder() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileSystemContextTests> "Move_Folder" None

    [<Test>]
    member this.Copy_Folder() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileSystemContextTests> "Copy_Folder" None

    [<Test>]
    member this.Folder_Delete() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileSystemContextTests> "Folder_Delete" None

    [<Test>]
    member this.Folder_Data_Populated() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileSystemContextTests> "Folder_Data_Populated" None
