namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DotNetTests() =
    inherit ModularPipelines.UnitTests.Helpers.DotNetTests()

    [<Test>]
    [<Skip("Flaky on CI - dotnet list package on full solution times out")>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.DotNetTests> "Has_Not_Errored" 0 None

    [<Test>]
    [<Skip("Temporarily disabled")>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.DotNetTests> "Format_Has_Not_Errored" 0 None

