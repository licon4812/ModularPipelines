namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type CircularDependencyDetectionTests() =
    inherit ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests> "ValidateNoCycles_WithDirectCycle_ThrowsCircularDependencyException" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests> "ValidateNoCycles_WithTripleCycle_ThrowsCircularDependencyException" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests> "ValidateNoCycles_WithLinearChain_DoesNotThrow" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests> "ValidateNoCycles_WithIndependentModules_DoesNotThrow" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests> "ValidateNoCycles_WithEmptyCollection_DoesNotThrow" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests> "ValidateNoCycles_WithComplexGraphContainingCycle_ThrowsCircularDependencyException" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests> "ValidateNoCycles_ExceptionContainsCycleTypes" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests> "ValidateNoCycles_ExceptionMessageShowsCyclePath" 0 None

    [<Test>]
    member this.Test_9() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests> "AddModulesFromAssembly_WithCircularDependency_ThrowsAtRegistrationTime" 0 None

    [<Test>]
    member this.Test_10() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests> "CreateWithCyclePath_FormatsMessageCorrectly" 0 None

    [<Test>]
    member this.Test_11() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.CircularDependencyDetectionTests> "CreateWithCyclePath_HighlightsStartAndEndOfCycle" 0 None

