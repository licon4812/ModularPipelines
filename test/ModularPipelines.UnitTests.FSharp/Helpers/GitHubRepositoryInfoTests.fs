namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type GitHubRepositoryInfoTests() =
    inherit ModularPipelines.UnitTests.Helpers.GitHubRepositoryInfoTests()

    [<Test>]
    member this.GitHub_Repository_Information_Is_Populated() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.GitHubRepositoryInfoTests> "GitHub_Repository_Information_Is_Populated" None
