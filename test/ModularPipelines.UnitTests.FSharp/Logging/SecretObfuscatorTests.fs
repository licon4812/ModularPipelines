namespace ModularPipelines.UnitTests.FSharp.Logging

open ModularPipelines.UnitTests.Logging
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type SecretObfuscatorTests() =
    inherit ModularPipelines.UnitTests.Logging.SecretObfuscatorTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SecretObfuscatorTests> "GitHubActions_MasksSecrets" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SecretObfuscatorTests> "DoesNotMaskSecrets_WhenNotGitHubActions" 0 None

