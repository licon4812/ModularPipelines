namespace ModularPipelines.UnitTests.FSharp.Execution

open ModularPipelines.UnitTests.Execution
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type AlwaysRunTests() =
    inherit ModularPipelines.UnitTests.Execution.AlwaysRunTests()

    [<Test>]
    member this.AlwaysRunModules_Will_Run_Even_With_Exception() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Execution.AlwaysRunTests> "AlwaysRunModules_Will_Run_Even_With_Exception" None
