namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DirectCollisionTests() =
    inherit ModularPipelines.UnitTests.Dependencies.DirectCollisionTests()

    [<Test>]
    member this.Modules_Dependent_On_Each_Other_Throws_Exception() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DirectCollisionTests> "Modules_Dependent_On_Each_Other_Throws_Exception" None
