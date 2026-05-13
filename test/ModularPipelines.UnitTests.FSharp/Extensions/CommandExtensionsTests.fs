namespace ModularPipelines.UnitTests.FSharp.Extensions

open ModularPipelines.UnitTests.Extensions
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type CommandExtensionsTests() =
    inherit ModularPipelines.UnitTests.Extensions.CommandExtensionsTests()

    [<Test>]
    member this.ToToolOptions_SingleArg() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Extensions.CommandExtensionsTests> "ToToolOptions_SingleArg" None

    [<Test>]
    member this.ToToolOptions_MultipleArgs() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Extensions.CommandExtensionsTests> "ToToolOptions_MultipleArgs" None

    [<Test>]
    member this.ToToolOptions_MultipleArgs_IEnumerable() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Extensions.CommandExtensionsTests> "ToToolOptions_MultipleArgs_IEnumerable" None

    [<Test>]
    member this.WithArguments_AddsToExisting() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Extensions.CommandExtensionsTests> "WithArguments_AddsToExisting" None
