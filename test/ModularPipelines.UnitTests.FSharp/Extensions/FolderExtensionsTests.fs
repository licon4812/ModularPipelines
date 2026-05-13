namespace ModularPipelines.UnitTests.FSharp.Extensions

open ModularPipelines.UnitTests.Extensions
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type FolderExtensionsTests() =
    inherit ModularPipelines.UnitTests.Extensions.FolderExtensionsTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Extensions.FolderExtensionsTests> "EnumerablePaths" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Extensions.FolderExtensionsTests> "ListPaths" 0 None

