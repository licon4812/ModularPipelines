namespace ModularPipelines.UnitTests.FSharp.FileSystem

open ModularPipelines.UnitTests.FileSystem
open ModularPipelines.UnitTests.FSharp
open ModularPipelines.UnitTests.Attributes
open TUnit.Core

type FileTests() =
    inherit ModularPipelines.UnitTests.FileSystem.FileTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "Delete" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "MoveTo" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "Data_Is_Populated" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "CopyTo" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "CreateFile" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "ReadEmptyFile" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "ReadWriteFile" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "ReadWriteLinesFile" 0 None

    [<Test>]
    member this.Test_9() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "ReadWriteBytesFile" 0 None

    [<Test>]
    member this.Test_10() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "WriteStreamFile" 0 None

    [<Test>]
    member this.Test_11() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "ReadWriteReadOnlyMemoryBytesFile" 0 None

    [<Test>]
    member this.Test_12() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "ReadWriteStreamFile" 0 None

    [<Test>]
    member this.Test_13() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "Null_FileInfo_Implicit_Cast" 0 None

    [<Test>]
    member this.Test_14() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "Null_String_Implicit_Cast" 0 None

    [<Test>]
    member this.Test_15() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "FileInfo_Implicit_Cast" 0 None

    [<Test>]
    member this.Test_16() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "String_Implicit_Cast" 0 None

    [<Test>]
    [<WindowsOnlyTest>]
    member this.Test_17() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "Attributes" 0 None

    [<Test>]
    member this.Test_18() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "EqualityTrue" 0 None

    [<Test>]
    member this.Test_19() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "EqualityFalse" 0 None

    [<Test>]
    member this.Test_20() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "GlobTests" 0 (Some 0)

    [<Test>]
    member this.Test_21() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "GlobTests" 0 (Some 1)

    [<Test>]
    member this.Test_22() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "GlobTests" 0 (Some 2)

    [<Test>]
    member this.Test_23() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "GlobTests" 0 (Some 3)

    [<Test>]
    member this.Test_24() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "GlobTest2" 0 None

    [<Test>]
    member this.Test_25() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "AssertExists" 0 None

    [<Test>]
    member this.Test_26() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "AssertExists_ThrowsWhenNotExists" 0 None

    [<Test>]
    member this.Test_27() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "AssertExists_ThrowsWhenNull" 0 None

    [<Test>]
    member this.Test_28() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "MoveTo_Folder" 0 None

    [<Test>]
    member this.Test_29() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.FileTests> "CopyTo_Folder" 0 None

