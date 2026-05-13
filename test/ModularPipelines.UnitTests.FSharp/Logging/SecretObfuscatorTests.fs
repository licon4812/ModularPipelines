namespace ModularPipelines.UnitTests.FSharp.Logging

open ModularPipelines.UnitTests.Logging
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type SecretObfuscatorTests() =
    inherit ModularPipelines.UnitTests.Logging.SecretObfuscatorTests()

    [<Test>]
    member this.GitHubActions_MasksSecrets() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SecretObfuscatorTests> "GitHubActions_MasksSecrets" None

    [<Test>]
    member this.DoesNotMaskSecrets_WhenNotGitHubActions() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SecretObfuscatorTests> "DoesNotMaskSecrets_WhenNotGitHubActions" None
