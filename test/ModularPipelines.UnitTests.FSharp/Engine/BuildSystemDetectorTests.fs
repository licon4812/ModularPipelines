namespace ModularPipelines.UnitTests.FSharp.Engine

open System
open ModularPipelines.Context
open ModularPipelines.Enums
open Moq
open TUnit.Assertions
open TUnit.Assertions.Extensions
open TUnit.Assertions.FSharp.Operations
open TUnit.Core

type BuildSystemDetectorTests() =
    let createDetector (environmentVariableName: string option) =
        let environmentVariables = Mock<IEnvironmentVariables>()

        match environmentVariableName with
        | Some name ->
            environmentVariables
                .Setup(fun x -> x.GetEnvironmentVariable(name, It.IsAny<EnvironmentVariableTarget>()))
                .Returns("dummy value")
            |> ignore
        | None -> ()

        BuildSystemDetector(environmentVariables.Object)

    [<Test>]
    member _.When_No_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_False() = async {
        let buildSystemDetector = createDetector None
        do! check(Assert.That(buildSystemDetector.IsKnownBuildAgent).IsFalse())
    }

    [<Test>]
    [<Arguments("TF_BUILD")>]
    [<Arguments("TEAMCITY_VERSION")>]
    [<Arguments("GITHUB_ACTIONS")>]
    [<Arguments("JENKINS_URL")>]
    [<Arguments("GITLAB_CI")>]
    [<Arguments("BITBUCKET_BUILD_NUMBER")>]
    [<Arguments("TRAVIS")>]
    [<Arguments("APPVEYOR")>]
    member _.When_Known_BuildAgent_Variable_Then_IsKnownBuildAgent_Returns_True(environmentVariableName: string) = async {
        let buildSystemDetector = createDetector (Some environmentVariableName)
        do! check(Assert.That(buildSystemDetector.IsKnownBuildAgent).IsTrue())
    }

    [<Test>]
    member _.Each_Property_Returns_Result() = async {
        let buildSystemDetector = createDetector None

        do! check(Assert.That(buildSystemDetector.IsRunningOnBitbucket).IsFalse())
        do! check(Assert.That(buildSystemDetector.IsRunningOnJenkins).IsFalse())
        do! check(Assert.That(buildSystemDetector.IsRunningOnAzurePipelines).IsFalse())
        do! check(Assert.That(buildSystemDetector.IsRunningOnTeamCity).IsFalse())
        do! check(Assert.That(buildSystemDetector.IsRunningOnGitHubActions || not buildSystemDetector.IsRunningOnGitHubActions).IsTrue())
        do! check(Assert.That(buildSystemDetector.IsRunningOnAppVeyor).IsFalse())
        do! check(Assert.That(buildSystemDetector.IsRunningOnGitLab).IsFalse())
        do! check(Assert.That(buildSystemDetector.IsRunningOnTravisCI).IsFalse())
    }

    [<Test>]
    [<Arguments("TF_BUILD", BuildSystem.AzurePipelines)>]
    [<Arguments("TEAMCITY_VERSION", BuildSystem.TeamCity)>]
    [<Arguments("GITHUB_ACTIONS", BuildSystem.GitHubActions)>]
    [<Arguments("JENKINS_URL", BuildSystem.Jenkins)>]
    [<Arguments("GITLAB_CI", BuildSystem.GitLab)>]
    [<Arguments("BITBUCKET_BUILD_NUMBER", BuildSystem.Bitbucket)>]
    [<Arguments("TRAVIS", BuildSystem.TravisCI)>]
    [<Arguments("APPVEYOR", BuildSystem.AppVeyor)>]
    [<Arguments("blah", BuildSystem.Unknown)>]
    member _.Expected_Build_Agent(environmentVariableName: string, expectedBuildSystem: BuildSystem) = async {
        let buildSystemDetector = createDetector (Some environmentVariableName)
        do! check(Assert.That(buildSystemDetector.GetCurrentBuildSystem()).IsEqualTo(expectedBuildSystem))
    }
