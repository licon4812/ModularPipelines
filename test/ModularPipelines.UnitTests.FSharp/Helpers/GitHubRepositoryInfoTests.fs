namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type GitHubRepositoryInfoTests() =
    inherit ModularPipelines.UnitTests.Helpers.GitHubRepositoryInfoTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.GitHubRepositoryInfoTests> "GitHub_Repository_Information_Is_Populated" 0 None

