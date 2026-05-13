namespace ModularPipelines.UnitTests.FSharp.Engine

open ModularPipelines.UnitTests.Engine
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DependencyTreeFormatterTests() =
    inherit ModularPipelines.UnitTests.Engine.DependencyTreeFormatterTests()

    [<Test>]
    member this.FormatTree_SingleModule_NoDependencies_ReturnsTreeWithSingleNode() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.DependencyTreeFormatterTests> "FormatTree_SingleModule_NoDependencies_ReturnsTreeWithSingleNode" None

    [<Test>]
    member this.FormatTree_LinearChain_ReturnsTreeWithCorrectHierarchy() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.DependencyTreeFormatterTests> "FormatTree_LinearChain_ReturnsTreeWithCorrectHierarchy" None

    [<Test>]
    member this.FormatTree_MultipleRoots_ReturnsTreeWithAllRoots() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.DependencyTreeFormatterTests> "FormatTree_MultipleRoots_ReturnsTreeWithAllRoots" None

    [<Test>]
    member this.FormatTree_SharedModule_MarkedAsReference_OnSecondOccurrence() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.DependencyTreeFormatterTests> "FormatTree_SharedModule_MarkedAsReference_OnSecondOccurrence" None

    [<Test>]
    member this.FormatTree_DiamondDependency_ShowsReferenceMarkerForSharedLeaf() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.DependencyTreeFormatterTests> "FormatTree_DiamondDependency_ShowsReferenceMarkerForSharedLeaf" None

    [<Test>]
    member this.FormatTree_EmptyCollection_OnlyContainsHeader() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.DependencyTreeFormatterTests> "FormatTree_EmptyCollection_OnlyContainsHeader" None

    [<Test>]
    member this.FormatTree_AlreadyPrintedRoot_SkipsIt() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.DependencyTreeFormatterTests> "FormatTree_AlreadyPrintedRoot_SkipsIt" None
