namespace ModularPipelines.UnitTests.FSharp.Extensions

open ModularPipelines.UnitTests.Extensions
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type FolderExtensionsTests() =
    inherit ModularPipelines.UnitTests.Extensions.FolderExtensionsTests()

    [<Test>]
    member this.EnumerablePaths() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Extensions.FolderExtensionsTests> "EnumerablePaths" None

    [<Test>]
    member this.ListPaths() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Extensions.FolderExtensionsTests> "ListPaths" None
