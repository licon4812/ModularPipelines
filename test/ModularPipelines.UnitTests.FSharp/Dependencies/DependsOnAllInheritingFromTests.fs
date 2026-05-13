namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DependsOnAllInheritingFromTests() =
    inherit ModularPipelines.UnitTests.Dependencies.DependsOnAllInheritingFromTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnAllInheritingFromTests> "No_Exception_Thrown_When_Dependent_Module_Present" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DependsOnAllInheritingFromTests> "DependsOnAllModulesInheritingFrom_Works_With_Open_Generic_Types" 0 None

