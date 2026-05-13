namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DockerTests() =
    inherit ModularPipelines.UnitTests.Helpers.DockerTests()

    [<Test>]
    member this.DockerBuild_CorrectInputCommand() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.DockerTests> "DockerBuild_CorrectInputCommand" None
