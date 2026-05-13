namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

[<TUnit.Core.NotInParallel>]
type DotNetTestResultsTests() =
    inherit ModularPipelines.UnitTests.Helpers.DotNetTestResultsTests()

    [<Test>]
    member this.Has_Errored() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.DotNetTestResultsTests> "Has_Errored" None

    [<Test>]
    member this.Has_Not_Errored() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.DotNetTestResultsTests> "Has_Not_Errored" None

    [<Test>]
    member this.Can_Parse_Trx_Manually() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.DotNetTestResultsTests> "Can_Parse_Trx_Manually" None

    [<Test>]
    member this.Can_Parse_Trx_Using_Helper() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.DotNetTestResultsTests> "Can_Parse_Trx_Using_Helper" None
