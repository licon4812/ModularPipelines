namespace ModularPipelines.UnitTests.FSharp.FileSystem

open ModularPipelines.UnitTests.FileSystem
open ModularPipelines.UnitTests.FSharp
open ModularPipelines.UnitTests.Attributes
open TUnit.Core

type FileTests() =
    inherit ModularPipelines.UnitTests.FileSystem.FileTests()

    [<Test>]
    member this.Delete() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "Delete" None

    [<Test>]
    member this.MoveTo() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "MoveTo" None

    [<Test>]
    member this.Data_Is_Populated() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "Data_Is_Populated" None

    [<Test>]
    member this.CopyTo() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "CopyTo" None

    [<Test>]
    member this.CreateFile() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "CreateFile" None

    [<Test>]
    member this.ReadEmptyFile() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "ReadEmptyFile" None

    [<Test>]
    member this.ReadWriteFile() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "ReadWriteFile" None

    [<Test>]
    member this.ReadWriteLinesFile() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "ReadWriteLinesFile" None

    [<Test>]
    member this.ReadWriteBytesFile() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "ReadWriteBytesFile" None

    [<Test>]
    member this.WriteStreamFile() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "WriteStreamFile" None

    [<Test>]
    member this.ReadWriteReadOnlyMemoryBytesFile() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "ReadWriteReadOnlyMemoryBytesFile" None

    [<Test>]
    member this.ReadWriteStreamFile() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "ReadWriteStreamFile" None

    [<Test>]
    member this.Null_FileInfo_Implicit_Cast() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "Null_FileInfo_Implicit_Cast" None

    [<Test>]
    member this.Null_String_Implicit_Cast() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "Null_String_Implicit_Cast" None

    [<Test>]
    member this.FileInfo_Implicit_Cast() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "FileInfo_Implicit_Cast" None

    [<Test>]
    member this.String_Implicit_Cast() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "String_Implicit_Cast" None

    [<Test>]
    [<WindowsOnlyTest>]
    member this.Attributes() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "Attributes" None

    [<Test>]
    member this.EqualityTrue() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "EqualityTrue" None

    [<Test>]
    member this.EqualityFalse() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "EqualityFalse" None

    [<Test>]
    member this.GlobTests_Arguments1() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "GlobTests" (Some 0)

    [<Test>]
    member this.GlobTests_Arguments2() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "GlobTests" (Some 1)

    [<Test>]
    member this.GlobTests_Arguments3() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "GlobTests" (Some 2)

    [<Test>]
    member this.GlobTests_Arguments4() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "GlobTests" (Some 3)

    [<Test>]
    member this.GlobTest2() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "GlobTest2" None

    [<Test>]
    member this.AssertExists() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "AssertExists" None

    [<Test>]
    member this.AssertExists_ThrowsWhenNotExists() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "AssertExists_ThrowsWhenNotExists" None

    [<Test>]
    member this.AssertExists_ThrowsWhenNull() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "AssertExists_ThrowsWhenNull" None

    [<Test>]
    member this.MoveTo_Folder() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "MoveTo_Folder" None

    [<Test>]
    member this.CopyTo_Folder() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "CopyTo_Folder" None
