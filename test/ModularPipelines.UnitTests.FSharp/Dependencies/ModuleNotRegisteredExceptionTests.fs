namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleNotRegisteredExceptionTests() =
    inherit ModularPipelines.UnitTests.Dependencies.ModuleNotRegisteredExceptionTests()

    [<Test>]
    member this.Module_Getting_Non_Registered_Module_With_Optional_Dep_Throws_ModuleFailedException() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.ModuleNotRegisteredExceptionTests> "Module_Getting_Non_Registered_Module_With_Optional_Dep_Throws_ModuleFailedException" None

    [<Test>]
    member this.Module_With_Required_Dependency_Auto_Registers_Missing_Module() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.ModuleNotRegisteredExceptionTests> "Module_With_Required_Dependency_Auto_Registers_Missing_Module" None

    [<Test>]
    member this.Module_Getting_Registered_Module_Does_Not_Throw_Exception() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.ModuleNotRegisteredExceptionTests> "Module_Getting_Registered_Module_Does_Not_Throw_Exception" None
