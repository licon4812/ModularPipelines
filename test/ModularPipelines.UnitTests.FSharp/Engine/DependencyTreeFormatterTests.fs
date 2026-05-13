namespace ModularPipelines.UnitTests.FSharp.Engine

open ModularPipelines.UnitTests.Engine
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DependencyTreeFormatterTests() =
    inherit ModularPipelines.UnitTests.Engine.DependencyTreeFormatterTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.DependencyTreeFormatterTests> "FormatTree_SingleModule_NoDependencies_ReturnsTreeWithSingleNode" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.DependencyTreeFormatterTests> "FormatTree_LinearChain_ReturnsTreeWithCorrectHierarchy" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.DependencyTreeFormatterTests> "FormatTree_MultipleRoots_ReturnsTreeWithAllRoots" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.DependencyTreeFormatterTests> "FormatTree_SharedModule_MarkedAsReference_OnSecondOccurrence" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.DependencyTreeFormatterTests> "FormatTree_DiamondDependency_ShowsReferenceMarkerForSharedLeaf" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.DependencyTreeFormatterTests> "FormatTree_EmptyCollection_OnlyContainsHeader" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.DependencyTreeFormatterTests> "FormatTree_AlreadyPrintedRoot_SkipsIt" 0 None

