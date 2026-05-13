namespace ModularPipelines.UnitTests.FSharp.Extensions

open ModularPipelines.UnitTests.Extensions
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type BooleanExtensionTests() =
    inherit ModularPipelines.UnitTests.Extensions.BooleanExtensionTests()

    [<Test>]
    member this.True() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Extensions.BooleanExtensionTests> "True" None

    [<Test>]
    member this.False() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Extensions.BooleanExtensionTests> "False" None
