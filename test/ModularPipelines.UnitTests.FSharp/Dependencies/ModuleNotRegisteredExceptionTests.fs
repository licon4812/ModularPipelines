namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleNotRegisteredExceptionTests() =
    inherit ModularPipelines.UnitTests.Dependencies.ModuleNotRegisteredExceptionTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.ModuleNotRegisteredExceptionTests> "Module_Getting_Non_Registered_Module_With_Optional_Dep_Throws_ModuleFailedException" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.ModuleNotRegisteredExceptionTests> "Module_With_Required_Dependency_Auto_Registers_Missing_Module" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.ModuleNotRegisteredExceptionTests> "Module_Getting_Registered_Module_Does_Not_Throw_Exception" 0 None

