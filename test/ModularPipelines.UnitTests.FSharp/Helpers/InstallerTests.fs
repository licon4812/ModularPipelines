namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type InstallerTests() =
    inherit ModularPipelines.UnitTests.Helpers.InstallerTests()

    [<Test>]
    [<Skip("Avoid installing things on people's machines")>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.InstallerTests> "Can_Install" 0 None

