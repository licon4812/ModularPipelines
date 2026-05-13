namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DependsOnTests() =
    inherit ModularPipelines.UnitTests.Dependencies.DependsOnTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnTests> "No_Exception_Thrown_When_Dependent_Module_Present" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnTests> "No_Exception_Thrown_When_Dependent_Module_Present_With_Optional" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnTests> "Required_Dependency_Is_Auto_Registered_When_Missing" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnTests> "Optional_Dependency_Not_Auto_Registered_When_Missing" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnTests> "No_Exception_Thrown_When_Optional_Dependency_Missing_And_Get_If_Registered_Called" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnTests> "Exception_Thrown_When_Optional_Dependency_Missing_And_Get_Module_Called" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnTests> "Depends_On_Self_Module_Throws_Exception" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnTests> "Depends_On_Non_Module_Throws_Exception" 0 None

    [<Test>]
    member this.Test_9() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnTests> "Optional_Dependency_Works_When_Missing" 0 None

    [<Test>]
    member this.Test_10() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnTests> "Required_Dependency_Auto_Registers_Missing_Module" 0 None

    [<Test>]
    member this.Test_11() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnTests> "Optional_Dependency_Returns_Null_When_GetModuleIfRegistered_Called_On_Unregistered" 0 None

