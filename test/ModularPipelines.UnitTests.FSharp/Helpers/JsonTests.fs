namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type JsonTests() =
    inherit ModularPipelines.UnitTests.Helpers.JsonTests()

    [<Test>]
    member this.Can_Serialize() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.JsonTests> "Can_Serialize" None

    [<Test>]
    member this.Can_Serialize_With_Options() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.JsonTests> "Can_Serialize_With_Options" None

    [<Test>]
    member this.Can_Deserialize() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.JsonTests> "Can_Deserialize" None

    [<Test>]
    member this.Can_Deserialize_With_Options() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.JsonTests> "Can_Deserialize_With_Options" None
