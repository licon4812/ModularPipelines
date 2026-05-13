namespace ModularPipelines.UnitTests.FSharp.Context

open ModularPipelines.UnitTests.Context
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ContextExtensionsTests() =
    inherit ModularPipelines.UnitTests.Context.ContextExtensionsTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.ContextExtensionsTests> "GetService_ShouldResolveFromDI" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.ContextExtensionsTests> "GetService_WhenServiceNotRegistered_ShouldThrow" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.ContextExtensionsTests> "TryGetService_ShouldReturnServiceOrNull" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.ContextExtensionsTests> "TryGetService_WhenServiceExists_ShouldReturnService" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.ContextExtensionsTests> "GetConfigValue_ShouldReturnConfigurationValue" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.ContextExtensionsTests> "GetRequiredConfigValue_WhenValueExists_ShouldReturnValue" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.ContextExtensionsTests> "GetRequiredConfigValue_WhenValueMissing_ShouldThrow" 0 None

