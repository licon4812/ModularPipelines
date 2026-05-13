namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type EmailTests() =
    inherit ModularPipelines.UnitTests.Helpers.EmailTests()

    [<Test>]
    member this.Can_Send_Email() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.EmailTests> "Can_Send_Email" None
