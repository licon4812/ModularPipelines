namespace ModularPipelines.UnitTests.FSharp.Logging

open ModularPipelines.UnitTests.Logging
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type LoggingSecretTests() =
    inherit ModularPipelines.UnitTests.Logging.LoggingSecretTests()

    [<Test>]
    member this.SecretIsCensored_Arguments1() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.LoggingSecretTests> "SecretIsCensored" (Some 0)

    [<Test>]
    member this.SecretIsCensored_Arguments2() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.LoggingSecretTests> "SecretIsCensored" (Some 1)

    [<Test>]
    member this.SecretIsCensored_Arguments3() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.LoggingSecretTests> "SecretIsCensored" (Some 2)
