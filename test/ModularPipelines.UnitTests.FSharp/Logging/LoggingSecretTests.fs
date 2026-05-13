namespace ModularPipelines.UnitTests.FSharp.Logging

open ModularPipelines.UnitTests.Logging
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type LoggingSecretTests() =
    inherit ModularPipelines.UnitTests.Logging.LoggingSecretTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.LoggingSecretTests> "SecretIsCensored" 0 (Some 0)

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.LoggingSecretTests> "SecretIsCensored" 0 (Some 1)

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.LoggingSecretTests> "SecretIsCensored" 0 (Some 2)

