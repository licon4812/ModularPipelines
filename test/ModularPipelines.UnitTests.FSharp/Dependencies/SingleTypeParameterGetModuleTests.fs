namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type SingleTypeParameterGetModuleTests() =
    inherit ModularPipelines.UnitTests.Dependencies.SingleTypeParameterGetModuleTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.SingleTypeParameterGetModuleTests> "GetModule_SingleTypeParameter_ReturnsCorrectlyTypedResult" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.SingleTypeParameterGetModuleTests> "GetModule_SingleTypeParameter_WithComplexType_InfersTypeCorrectly" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.SingleTypeParameterGetModuleTests> "GetModuleIfRegistered_SingleTypeParameter_ReturnsModule_WhenRegistered" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.SingleTypeParameterGetModuleTests> "GetModuleIfRegistered_SingleTypeParameter_ReturnsNull_WhenNotRegistered" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.SingleTypeParameterGetModuleTests> "GetModule_SingleTypeParameter_ThrowsModuleReferencingSelfException" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.SingleTypeParameterGetModuleTests> "GetModule_SingleTypeParameter_ThrowsModuleNotRegisteredException" 0 None

