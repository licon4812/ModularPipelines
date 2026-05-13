namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleTagAttributeTests() =
    inherit ModularPipelines.UnitTests.Dependencies.ModuleTagAttributeTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.ModuleTagAttributeTests> "Constructor_WithValidTag_SetsTagProperty" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.ModuleTagAttributeTests> "Constructor_WithNullTag_ThrowsArgumentException" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.ModuleTagAttributeTests> "Constructor_WithEmptyTag_ThrowsArgumentException" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.ModuleTagAttributeTests> "Constructor_WithWhitespaceTag_ThrowsArgumentException" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.ModuleTagAttributeTests> "Attribute_AllowsMultiple" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.ModuleTagAttributeTests> "Attribute_IsInheritable" 0 None

