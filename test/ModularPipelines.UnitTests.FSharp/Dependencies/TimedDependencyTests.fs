namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type TimedDependencyTests() =
    inherit ModularPipelines.UnitTests.Dependencies.TimedDependencyTests()

    [<Test>]
    member this.OneSecondModule_WillWaitForFiveSecondModule_ThenExecute() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.TimedDependencyTests> "OneSecondModule_WillWaitForFiveSecondModule_ThenExecute" None
