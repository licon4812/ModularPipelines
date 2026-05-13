namespace ModularPipelines.UnitTests.FSharp.Extensions

open ModularPipelines.UnitTests.Extensions
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type FileExtensionsTests() =
    inherit ModularPipelines.UnitTests.Extensions.FileExtensionsTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Extensions.FileExtensionsTests> "EnumerablePaths" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Extensions.FileExtensionsTests> "ListPaths" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Extensions.FileExtensionsTests> "NotFoundMessage" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Extensions.FileExtensionsTests> "NotFoundWithoutMessage" 0 None

