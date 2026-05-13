namespace ModularPipelines.UnitTests.FSharp.Registration

open ModularPipelines.UnitTests.Registration
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleRegistrationBuilderTests() =
    inherit ModularPipelines.UnitTests.Registration.ModuleRegistrationBuilderTests()

    [<Test>]
    member this.AddModule_ReturnsBuilder_WithServicesAccess() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationBuilderTests> "AddModule_ReturnsBuilder_WithServicesAccess" None

    [<Test>]
    member this.AddModule_ChainedCalls_RegistersAllModules() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationBuilderTests> "AddModule_ChainedCalls_RegistersAllModules" None

    [<Test>]
    member this.WithTags_DoesNotThrow() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationBuilderTests> "WithTags_DoesNotThrow" None

    [<Test>]
    member this.WithCategory_DoesNotThrow() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationBuilderTests> "WithCategory_DoesNotThrow" None

    [<Test>]
    member this.WithTags_MultipleCalls_DoesNotThrow() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationBuilderTests> "WithTags_MultipleCalls_DoesNotThrow" None

    [<Test>]
    member this.WithCategory_CanChainWithAddModule() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationBuilderTests> "WithCategory_CanChainWithAddModule" None

    [<Test>]
    member this.Builder_CanAddRequirement() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationBuilderTests> "Builder_CanAddRequirement" None

    [<Test>]
    member this.Builder_CanConfigure() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationBuilderTests> "Builder_CanConfigure" None

    [<Test>]
    member this.MustAsync() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationBuilderTests> "MustAsync" None
