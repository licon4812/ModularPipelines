namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleTagAttributeTests() =
    inherit ModularPipelines.UnitTests.Dependencies.ModuleTagAttributeTests()

    [<Test>]
    member this.Constructor_WithValidTag_SetsTagProperty() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.ModuleTagAttributeTests> "Constructor_WithValidTag_SetsTagProperty" None

    [<Test>]
    member this.Constructor_WithNullTag_ThrowsArgumentException() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.ModuleTagAttributeTests> "Constructor_WithNullTag_ThrowsArgumentException" None

    [<Test>]
    member this.Constructor_WithEmptyTag_ThrowsArgumentException() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.ModuleTagAttributeTests> "Constructor_WithEmptyTag_ThrowsArgumentException" None

    [<Test>]
    member this.Constructor_WithWhitespaceTag_ThrowsArgumentException() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.ModuleTagAttributeTests> "Constructor_WithWhitespaceTag_ThrowsArgumentException" None

    [<Test>]
    member this.Attribute_AllowsMultiple() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.ModuleTagAttributeTests> "Attribute_AllowsMultiple" None

    [<Test>]
    member this.Attribute_IsInheritable() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.ModuleTagAttributeTests> "Attribute_IsInheritable" None
