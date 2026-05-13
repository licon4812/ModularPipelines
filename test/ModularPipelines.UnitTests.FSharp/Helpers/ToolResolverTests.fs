namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ToolResolverTests() =
    inherit ModularPipelines.UnitTests.Helpers.ToolResolverTests()

    [<Test>]
    member this.ResolveTool_FromDirectAttribute_ReturnsTool() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.ToolResolverTests> "ResolveTool_FromDirectAttribute_ReturnsTool" None

    [<Test>]
    member this.ResolveTool_FromInheritedAttribute_ReturnsTool() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.ToolResolverTests> "ResolveTool_FromInheritedAttribute_ReturnsTool" None

    [<Test>]
    member this.ResolveTool_FromDeeplyInheritedAttribute_ReturnsTool() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.ToolResolverTests> "ResolveTool_FromDeeplyInheritedAttribute_ReturnsTool" None

    [<Test>]
    member this.ResolveTool_NoAttribute_ReturnsNull() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.ToolResolverTests> "ResolveTool_NoAttribute_ReturnsNull" None

    [<Test>]
    member this.ResolveTool_FromInstance_ReturnsToolFromAttribute() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.ToolResolverTests> "ResolveTool_FromInstance_ReturnsToolFromAttribute" None
