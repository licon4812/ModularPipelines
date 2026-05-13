namespace ModularPipelines.UnitTests.FSharp.Context

open ModularPipelines.UnitTests.Context
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ContextExtensionsTests() =
    inherit ModularPipelines.UnitTests.Context.ContextExtensionsTests()

    [<Test>]
    member this.GetService_ShouldResolveFromDI() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.ContextExtensionsTests> "GetService_ShouldResolveFromDI" None

    [<Test>]
    member this.GetService_WhenServiceNotRegistered_ShouldThrow() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.ContextExtensionsTests> "GetService_WhenServiceNotRegistered_ShouldThrow" None

    [<Test>]
    member this.TryGetService_ShouldReturnServiceOrNull() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.ContextExtensionsTests> "TryGetService_ShouldReturnServiceOrNull" None

    [<Test>]
    member this.TryGetService_WhenServiceExists_ShouldReturnService() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.ContextExtensionsTests> "TryGetService_WhenServiceExists_ShouldReturnService" None

    [<Test>]
    member this.GetConfigValue_ShouldReturnConfigurationValue() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.ContextExtensionsTests> "GetConfigValue_ShouldReturnConfigurationValue" None

    [<Test>]
    member this.GetRequiredConfigValue_WhenValueExists_ShouldReturnValue() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.ContextExtensionsTests> "GetRequiredConfigValue_WhenValueExists_ShouldReturnValue" None

    [<Test>]
    member this.GetRequiredConfigValue_WhenValueMissing_ShouldThrow() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.ContextExtensionsTests> "GetRequiredConfigValue_WhenValueMissing_ShouldThrow" None
