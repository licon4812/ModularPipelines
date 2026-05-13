namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DependsOnTests() =
    inherit ModularPipelines.UnitTests.Dependencies.DependsOnTests()

    [<Test>]
    member this.No_Exception_Thrown_When_Dependent_Module_Present() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnTests> "No_Exception_Thrown_When_Dependent_Module_Present" None

    [<Test>]
    member this.No_Exception_Thrown_When_Dependent_Module_Present_With_Optional() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnTests> "No_Exception_Thrown_When_Dependent_Module_Present_With_Optional" None

    [<Test>]
    member this.Required_Dependency_Is_Auto_Registered_When_Missing() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnTests> "Required_Dependency_Is_Auto_Registered_When_Missing" None

    [<Test>]
    member this.Optional_Dependency_Not_Auto_Registered_When_Missing() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnTests> "Optional_Dependency_Not_Auto_Registered_When_Missing" None

    [<Test>]
    member this.No_Exception_Thrown_When_Optional_Dependency_Missing_And_Get_If_Registered_Called() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnTests> "No_Exception_Thrown_When_Optional_Dependency_Missing_And_Get_If_Registered_Called" None

    [<Test>]
    member this.Exception_Thrown_When_Optional_Dependency_Missing_And_Get_Module_Called() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnTests> "Exception_Thrown_When_Optional_Dependency_Missing_And_Get_Module_Called" None

    [<Test>]
    member this.Depends_On_Self_Module_Throws_Exception() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnTests> "Depends_On_Self_Module_Throws_Exception" None

    [<Test>]
    member this.Depends_On_Non_Module_Throws_Exception() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnTests> "Depends_On_Non_Module_Throws_Exception" None

    [<Test>]
    member this.Optional_Dependency_Works_When_Missing() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnTests> "Optional_Dependency_Works_When_Missing" None

    [<Test>]
    member this.Required_Dependency_Auto_Registers_Missing_Module() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnTests> "Required_Dependency_Auto_Registers_Missing_Module" None

    [<Test>]
    member this.Optional_Dependency_Returns_Null_When_GetModuleIfRegistered_Called_On_Unregistered() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnTests> "Optional_Dependency_Returns_Null_When_GetModuleIfRegistered_Called_On_Unregistered" None
