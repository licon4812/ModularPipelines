namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type TimedDependencyTests() =
    inherit ModularPipelines.UnitTests.Dependencies.TimedDependencyTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.TimedDependencyTests> "OneSecondModule_WillWaitForFiveSecondModule_ThenExecute" 0 None

