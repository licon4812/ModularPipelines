namespace ModularPipelines.UnitTests.FSharp.Context

open ModularPipelines.UnitTests.Context
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type InterfaceVisibilityTests() =
    inherit ModularPipelines.UnitTests.Context.InterfaceVisibilityTests()

    [<Test>]
    member this.EngineInterfaces_ShouldBeInternal() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.InterfaceVisibilityTests> "EngineInterfaces_ShouldBeInternal" None

    [<Test>]
    member this.UserFacingContextInterfaces_ShouldBePublic() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.InterfaceVisibilityTests> "UserFacingContextInterfaces_ShouldBePublic" None

    [<Test>]
    member this.ExtensionPointInterfaces_ShouldBePublic() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.InterfaceVisibilityTests> "ExtensionPointInterfaces_ShouldBePublic" None

    [<Test>]
    member this.IPipelineServiceContainerWrapper_ShouldBeInternal() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.InterfaceVisibilityTests> "IPipelineServiceContainerWrapper_ShouldBeInternal" None
