namespace ModularPipelines.UnitTests.FSharp.FileSystem

open ModularPipelines.UnitTests.FileSystem
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type MockedFileSystemTests() =
    inherit ModularPipelines.UnitTests.FileSystem.MockedFileSystemTests()

    [<Test>]
    member this.Module_CanUseMockedFileSystem_ForReading() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.MockedFileSystemTests> "Module_CanUseMockedFileSystem_ForReading" None

    [<Test>]
    member this.Module_CanUseMockedFileSystem_ForWriting() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.MockedFileSystemTests> "Module_CanUseMockedFileSystem_ForWriting" None

    [<Test>]
    member this.Module_CanUseMockedFileSystem_ForFolderOperations() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.MockedFileSystemTests> "Module_CanUseMockedFileSystem_ForFolderOperations" None
