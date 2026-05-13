namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type InstallerTests() =
    inherit ModularPipelines.UnitTests.Helpers.InstallerTests()

    [<Test>]
    [<Skip("Avoid installing things on people's machines")>]
    member this.Can_Install() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.InstallerTests> "Can_Install" None
