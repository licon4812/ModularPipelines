namespace ModularPipelines.UnitTests.FSharp.FileSystem

open ModularPipelines.UnitTests.FileSystem
open ModularPipelines.UnitTests.FSharp
open ModularPipelines.UnitTests.Attributes
open TUnit.Core

type FolderTests() =
    inherit ModularPipelines.UnitTests.FileSystem.FolderTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "CleanFiles" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "CleanFolders" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "FindFile" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "FindFileLogs" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "FindFolder" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "Delete" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "MoveTo" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "CopyTo" 0 None

    [<Test>]
    member this.Test_9() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "Data_Is_Populated" 0 None

    [<Test>]
    member this.Test_10() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "CreateFolder" 0 None

    [<Test>]
    member this.Test_11() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "CreateFile" 0 None

    [<Test>]
    member this.Test_12() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "CreateSubfolder" 0 None

    [<Test>]
    member this.Test_13() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "Null_FileInfo_Implicit_Cast" 0 None

    [<Test>]
    member this.Test_14() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "Null_String_Implicit_Cast" 0 None

    [<Test>]
    member this.Test_15() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "FileInfo_Implicit_Cast" 0 None

    [<Test>]
    member this.Test_16() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "String_Implicit_Cast" 0 None

    [<Test>]
    [<WindowsOnlyTest>]
    member this.Test_17() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "Attributes" 0 None

    [<Test>]
    member this.Test_18() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "EqualityTrue" 0 None

    [<Test>]
    member this.Test_19() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "EqualityFalse" 0 None

    [<Test>]
    member this.Test_20() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "AssertExists" 0 None

    [<Test>]
    member this.Test_21() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "AssertExists_ThrowsWhenNotExists" 0 None

    [<Test>]
    member this.Test_22() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "AssertExists_ThrowsWhenNull" 0 None

    [<Test>]
    member this.Test_23() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "Searching_Files_With_Nested_Folders_Does_Not_Throw" 0 None

    [<Test>]
    member this.Test_24() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "GetFiles_With_Pattern_Does_Not_Throw" 0 None

    [<Test>]
    member this.Test_25() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FolderTests> "Searching_Folders_With_Nested_Structure_Does_Not_Throw" 0 None

