namespace ModularPipelines.UnitTests.FSharp.Registration

open ModularPipelines.UnitTests.Registration
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleRegistrationApiTests() =
    inherit ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests()

    [<Test>]
    member this.AddModules_TwoModules_RegistersBothModules() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests> "AddModules_TwoModules_RegistersBothModules" None

    [<Test>]
    member this.AddModules_ThreeModules_RegistersAllModules() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests> "AddModules_ThreeModules_RegistersAllModules" None

    [<Test>]
    member this.AddModules_FourModules_RegistersAllModules() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests> "AddModules_FourModules_RegistersAllModules" None

    [<Test>]
    member this.AddModules_FiveModules_RegistersAllModules() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests> "AddModules_FiveModules_RegistersAllModules" None

    [<Test>]
    member this.AddModules_SixModules_RegistersAllModules() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests> "AddModules_SixModules_RegistersAllModules" None

    [<Test>]
    member this.AddModules_CanChainWithAddModule() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests> "AddModules_CanChainWithAddModule" None

    [<Test>]
    member this.AddModules_CanChainMultipleCalls() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests> "AddModules_CanChainMultipleCalls" None

    [<Test>]
    member this.AddModulesFromAssemblyContainingType_RegistersModulesFromAssembly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests> "AddModulesFromAssemblyContainingType_RegistersModulesFromAssembly" None

    [<Test>]
    member this.AddModulesFromAssembly_RegistersModulesFromAssembly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests> "AddModulesFromAssembly_RegistersModulesFromAssembly" None

    [<Test>]
    member this.AddModulesFromAssemblyContainingType_CanChainWithAddModule() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests> "AddModulesFromAssemblyContainingType_CanChainWithAddModule" None

    [<Test>]
    member this.AddModulesFromAssembly_FiltersOutOpenGenericTypes() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Registration.ModuleRegistrationApiTests> "AddModulesFromAssembly_FiltersOutOpenGenericTypes" None
