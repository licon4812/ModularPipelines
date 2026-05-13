namespace ModularPipelines.UnitTests.FSharp.FileSystem

open ModularPipelines.UnitTests.FileSystem
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type MockedFileSystemTests() =
    inherit ModularPipelines.UnitTests.FileSystem.MockedFileSystemTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.MockedFileSystemTests> "Module_CanUseMockedFileSystem_ForReading" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.MockedFileSystemTests> "Module_CanUseMockedFileSystem_ForWriting" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.FileSystem.MockedFileSystemTests> "Module_CanUseMockedFileSystem_ForFolderOperations" 0 None

