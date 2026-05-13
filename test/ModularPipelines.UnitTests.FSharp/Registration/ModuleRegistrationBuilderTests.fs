namespace ModularPipelines.UnitTests.FSharp.Registration

open ModularPipelines.UnitTests.Registration
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleRegistrationBuilderTests() =
    inherit ModularPipelines.UnitTests.Registration.ModuleRegistrationBuilderTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationBuilderTests> "AddModule_ReturnsBuilder_WithServicesAccess" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationBuilderTests> "AddModule_ChainedCalls_RegistersAllModules" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationBuilderTests> "WithTags_DoesNotThrow" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationBuilderTests> "WithCategory_DoesNotThrow" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationBuilderTests> "WithTags_MultipleCalls_DoesNotThrow" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationBuilderTests> "WithCategory_CanChainWithAddModule" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationBuilderTests> "Builder_CanAddRequirement" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationBuilderTests> "Builder_CanConfigure" 0 None

