namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type XmlTests() =
    inherit ModularPipelines.UnitTests.Helpers.XmlTests()

    [<Test>]
    member this.Can_Serialize_With_Null() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.XmlTests> "Can_Serialize_With_Null" None

    [<Test>]
    member this.Can_Serialize_With_Array() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.XmlTests> "Can_Serialize_With_Array" None

    [<Test>]
    member this.Can_Serialize_With_Options() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.XmlTests> "Can_Serialize_With_Options" None

    [<Test>]
    member this.Can_Deserialize() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.XmlTests> "Can_Deserialize" None

    [<Test>]
    member this.Can_Deserialize_With_Options() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.XmlTests> "Can_Deserialize_With_Options" None
