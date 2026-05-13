namespace ModularPipelines.UnitTests.FSharp.Registration

open ModularPipelines.UnitTests.Registration
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleRegistrationApiTests() =
    inherit ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests> "AddModules_TwoModules_RegistersBothModules" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests> "AddModules_ThreeModules_RegistersAllModules" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests> "AddModules_FourModules_RegistersAllModules" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests> "AddModules_FiveModules_RegistersAllModules" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests> "AddModules_SixModules_RegistersAllModules" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests> "AddModules_CanChainWithAddModule" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests> "AddModules_CanChainMultipleCalls" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests> "AddModulesFromAssemblyContainingType_RegistersModulesFromAssembly" 0 None

    [<Test>]
    member this.Test_9() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests> "AddModulesFromAssembly_RegistersModulesFromAssembly" 0 None

    [<Test>]
    member this.Test_10() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests> "AddModulesFromAssemblyContainingType_CanChainWithAddModule" 0 None

    [<Test>]
    member this.Test_11() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests> "AddModulesFromAssembly_FiltersOutOpenGenericTypes" 0 None

