namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type CategoryFilterDependencyTests() =
    inherit ModularPipelines.UnitTests.Dependencies.CategoryFilterDependencyTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.CategoryFilterDependencyTests> "Optional_Dependency_Works_When_Filtered_By_Category" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.CategoryFilterDependencyTests> "Optional_Dependency_Is_Skipped_When_Filtered_By_Category" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.CategoryFilterDependencyTests> "Both_Categories_Run_Successfully" 0 None

