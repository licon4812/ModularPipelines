namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type CategoryFilterDependencyTests() =
    inherit ModularPipelines.UnitTests.Dependencies.CategoryFilterDependencyTests()

    [<Test>]
    member this.Optional_Dependency_Works_When_Filtered_By_Category() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.CategoryFilterDependencyTests> "Optional_Dependency_Works_When_Filtered_By_Category" None

    [<Test>]
    member this.Optional_Dependency_Is_Skipped_When_Filtered_By_Category() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.CategoryFilterDependencyTests> "Optional_Dependency_Is_Skipped_When_Filtered_By_Category" None

    [<Test>]
    member this.Both_Categories_Run_Successfully() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.CategoryFilterDependencyTests> "Both_Categories_Run_Successfully" None
