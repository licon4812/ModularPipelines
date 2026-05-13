namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type OneWayDependenciesNonCollisionTests() =
    inherit ModularPipelines.UnitTests.Dependencies.OneWayDependenciesNonCollisionTests()

    [<Test>]
    member this.Modules_Not_Dependent_On_Each_Other_Succeed() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.OneWayDependenciesNonCollisionTests> "Modules_Not_Dependent_On_Each_Other_Succeed" None
