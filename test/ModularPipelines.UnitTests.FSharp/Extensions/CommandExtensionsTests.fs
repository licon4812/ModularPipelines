namespace ModularPipelines.UnitTests.FSharp.Extensions

open ModularPipelines.UnitTests.Extensions
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type CommandExtensionsTests() =
    inherit ModularPipelines.UnitTests.Extensions.CommandExtensionsTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Extensions.CommandExtensionsTests> "ToToolOptions_SingleArg" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Extensions.CommandExtensionsTests> "ToToolOptions_MultipleArgs" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Extensions.CommandExtensionsTests> "ToToolOptions_MultipleArgs_IEnumerable" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Extensions.CommandExtensionsTests> "WithArguments_AddsToExisting" 0 None

