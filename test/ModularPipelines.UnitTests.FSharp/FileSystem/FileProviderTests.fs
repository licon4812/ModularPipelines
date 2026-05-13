namespace ModularPipelines.UnitTests.FSharp.FileSystem

open ModularPipelines.UnitTests.FileSystem
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type FileProviderTests() =
    inherit ModularPipelines.UnitTests.FileSystem.FileProviderTests()

    [<Test>]
    member this.ReadAsync_UsesProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileProviderTests> "ReadAsync_UsesProvider" None

    [<Test>]
    member this.WriteAsync_UsesProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileProviderTests> "WriteAsync_UsesProvider" None

    [<Test>]
    member this.Delete_UsesProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileProviderTests> "Delete_UsesProvider" None

    [<Test>]
    member this.CopyTo_ReturnsFileWithSameProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileProviderTests> "CopyTo_ReturnsFileWithSameProvider" None

    [<Test>]
    member this.MoveTo_ReturnsFileWithSameProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileProviderTests> "MoveTo_ReturnsFileWithSameProvider" None

    [<Test>]
    member this.DefaultConstructor_UsesSystemProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileProviderTests> "DefaultConstructor_UsesSystemProvider" None

    [<Test>]
    member this.ReadBytesAsync_UsesProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileProviderTests> "ReadBytesAsync_UsesProvider" None

    [<Test>]
    member this.WriteAsync_Bytes_UsesProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileProviderTests> "WriteAsync_Bytes_UsesProvider" None

    [<Test>]
    member this.WriteAsync_Lines_UsesProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileProviderTests> "WriteAsync_Lines_UsesProvider" None

    [<Test>]
    member this.AppendAsync_UsesProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileProviderTests> "AppendAsync_UsesProvider" None

    [<Test>]
    member this.AppendAsync_Lines_UsesProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileProviderTests> "AppendAsync_Lines_UsesProvider" None

    [<Test>]
    member this.Create_UsesProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileProviderTests> "Create_UsesProvider" None

    [<Test>]
    member this.GetStream_UsesProvider() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileProviderTests> "GetStream_UsesProvider" None

    [<Test>]
    member this.CopyToAsync_UsesProviderStreams() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.FileProviderTests> "CopyToAsync_UsesProviderStreams" None
