namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type CircularDependencyDetectionTests() =
    inherit ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests()

    [<Test>]
    member this.ValidateNoCycles_WithDirectCycle_ThrowsCircularDependencyException() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests> "ValidateNoCycles_WithDirectCycle_ThrowsCircularDependencyException" None

    [<Test>]
    member this.ValidateNoCycles_WithTripleCycle_ThrowsCircularDependencyException() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests> "ValidateNoCycles_WithTripleCycle_ThrowsCircularDependencyException" None

    [<Test>]
    member this.ValidateNoCycles_WithLinearChain_DoesNotThrow() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests> "ValidateNoCycles_WithLinearChain_DoesNotThrow" None

    [<Test>]
    member this.ValidateNoCycles_WithIndependentModules_DoesNotThrow() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests> "ValidateNoCycles_WithIndependentModules_DoesNotThrow" None

    [<Test>]
    member this.ValidateNoCycles_WithEmptyCollection_DoesNotThrow() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests> "ValidateNoCycles_WithEmptyCollection_DoesNotThrow" None

    [<Test>]
    member this.ValidateNoCycles_WithComplexGraphContainingCycle_ThrowsCircularDependencyException() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests> "ValidateNoCycles_WithComplexGraphContainingCycle_ThrowsCircularDependencyException" None

    [<Test>]
    member this.ValidateNoCycles_ExceptionContainsCycleTypes() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests> "ValidateNoCycles_ExceptionContainsCycleTypes" None

    [<Test>]
    member this.ValidateNoCycles_ExceptionMessageShowsCyclePath() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests> "ValidateNoCycles_ExceptionMessageShowsCyclePath" None

    [<Test>]
    member this.AddModulesFromAssembly_WithCircularDependency_ThrowsAtRegistrationTime() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests> "AddModulesFromAssembly_WithCircularDependency_ThrowsAtRegistrationTime" None

    [<Test>]
    member this.CreateWithCyclePath_FormatsMessageCorrectly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests> "CreateWithCyclePath_FormatsMessageCorrectly" None

    [<Test>]
    member this.CreateWithCyclePath_HighlightsStartAndEndOfCycle() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests> "CreateWithCyclePath_HighlightsStartAndEndOfCycle" None
