namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DotNetTests() =
    inherit ModularPipelines.UnitTests.Helpers.DotNetTests()

    [<Test>]
    [<Skip("Flaky on CI - dotnet list package on full solution times out")>]
    member this.Has_Not_Errored() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.DotNetTests> "Has_Not_Errored" None

    [<Test>]
    [<Skip("Temporarily disabled")>]
    member this.Format_Has_Not_Errored() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.DotNetTests> "Format_Has_Not_Errored" None
