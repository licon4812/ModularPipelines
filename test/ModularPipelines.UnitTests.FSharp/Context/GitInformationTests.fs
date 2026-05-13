namespace ModularPipelines.UnitTests.FSharp.Context

open ModularPipelines.UnitTests.Context
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type GitInformationTests() =
    inherit ModularPipelines.UnitTests.Context.GitInformationTests()

    [<Test>]
    member this.Can_Send_Request_With_String_To_Request_Implicit_Conversion() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.GitInformationTests> "Can_Send_Request_With_String_To_Request_Implicit_Conversion" None
