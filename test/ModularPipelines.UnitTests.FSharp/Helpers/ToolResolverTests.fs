namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ToolResolverTests() =
    inherit ModularPipelines.UnitTests.Helpers.ToolResolverTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.ToolResolverTests> "ResolveTool_FromDirectAttribute_ReturnsTool" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.ToolResolverTests> "ResolveTool_FromInheritedAttribute_ReturnsTool" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.ToolResolverTests> "ResolveTool_FromDeeplyInheritedAttribute_ReturnsTool" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.ToolResolverTests> "ResolveTool_NoAttribute_ReturnsNull" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.ToolResolverTests> "ResolveTool_FromInstance_ReturnsToolFromAttribute" 0 None

