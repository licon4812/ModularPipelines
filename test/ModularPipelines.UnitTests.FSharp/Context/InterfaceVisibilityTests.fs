namespace ModularPipelines.UnitTests.FSharp.Context

open ModularPipelines.UnitTests.Context
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type InterfaceVisibilityTests() =
    inherit ModularPipelines.UnitTests.Context.InterfaceVisibilityTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.InterfaceVisibilityTests> "EngineInterfaces_ShouldBeInternal" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.InterfaceVisibilityTests> "UserFacingContextInterfaces_ShouldBePublic" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.InterfaceVisibilityTests> "ExtensionPointInterfaces_ShouldBePublic" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.InterfaceVisibilityTests> "IPipelineServiceContainerWrapper_ShouldBeInternal" 0 None

