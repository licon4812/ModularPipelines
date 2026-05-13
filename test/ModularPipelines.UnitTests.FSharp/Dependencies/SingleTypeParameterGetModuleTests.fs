namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type SingleTypeParameterGetModuleTests() =
    inherit ModularPipelines.UnitTests.Dependencies.SingleTypeParameterGetModuleTests()

    [<Test>]
    member this.GetModule_SingleTypeParameter_ReturnsCorrectlyTypedResult() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.SingleTypeParameterGetModuleTests> "GetModule_SingleTypeParameter_ReturnsCorrectlyTypedResult" None

    [<Test>]
    member this.GetModule_SingleTypeParameter_WithComplexType_InfersTypeCorrectly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.SingleTypeParameterGetModuleTests> "GetModule_SingleTypeParameter_WithComplexType_InfersTypeCorrectly" None

    [<Test>]
    member this.GetModuleIfRegistered_SingleTypeParameter_ReturnsModule_WhenRegistered() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.SingleTypeParameterGetModuleTests> "GetModuleIfRegistered_SingleTypeParameter_ReturnsModule_WhenRegistered" None

    [<Test>]
    member this.GetModuleIfRegistered_SingleTypeParameter_ReturnsNull_WhenNotRegistered() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.SingleTypeParameterGetModuleTests> "GetModuleIfRegistered_SingleTypeParameter_ReturnsNull_WhenNotRegistered" None

    [<Test>]
    member this.GetModule_SingleTypeParameter_ThrowsModuleReferencingSelfException() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.SingleTypeParameterGetModuleTests> "GetModule_SingleTypeParameter_ThrowsModuleReferencingSelfException" None

    [<Test>]
    member this.GetModule_SingleTypeParameter_ThrowsModuleNotRegisteredException() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.SingleTypeParameterGetModuleTests> "GetModule_SingleTypeParameter_ThrowsModuleNotRegisteredException" None
