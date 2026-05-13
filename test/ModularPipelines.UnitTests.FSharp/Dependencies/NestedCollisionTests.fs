namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type NestedCollisionTests() =
    inherit ModularPipelines.UnitTests.Dependencies.NestedCollisionTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.NestedCollisionTests> "Modules_Dependent_On_Each_Other_Throws_Exception" 0 None

