namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DependsOnAllInheritingFromTests() =
    inherit ModularPipelines.UnitTests.Dependencies.DependsOnAllInheritingFromTests()

    [<Test>]
    member this.No_Exception_Thrown_When_Dependent_Module_Present() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnAllInheritingFromTests> "No_Exception_Thrown_When_Dependent_Module_Present" None

    [<Test>]
    member this.DependsOnAllModulesInheritingFrom_Works_With_Open_Generic_Types() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DependsOnAllInheritingFromTests> "DependsOnAllModulesInheritingFrom_Works_With_Open_Generic_Types" None
