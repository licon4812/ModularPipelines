namespace ModularPipelines.UnitTests.FSharp.Extensions

open ModularPipelines.UnitTests.Extensions
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type FileExtensionsTests() =
    inherit ModularPipelines.UnitTests.Extensions.FileExtensionsTests()

    [<Test>]
    member this.EnumerablePaths() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Extensions.FileExtensionsTests> "EnumerablePaths" None

    [<Test>]
    member this.ListPaths() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Extensions.FileExtensionsTests> "ListPaths" None

    [<Test>]
    member this.NotFoundMessage() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Extensions.FileExtensionsTests> "NotFoundMessage" None

    [<Test>]
    member this.NotFoundWithoutMessage() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Extensions.FileExtensionsTests> "NotFoundWithoutMessage" None
