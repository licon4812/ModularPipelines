namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type GitTests() =
    inherit ModularPipelines.UnitTests.Helpers.GitTests()

    [<Test>]
    member this.Has_Not_Errored() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.GitTests> "Has_Not_Errored" None

    [<Test>]
    member this.Standard_Output_Starts_With_Git_Version() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.GitTests> "Standard_Output_Starts_With_Git_Version" None

    [<Test>]
    member this.GitRootDirectory() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.GitTests> "GitRootDirectory" None

    [<Test>]
    member this.DefaultBranchName() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.GitTests> "DefaultBranchName" None
