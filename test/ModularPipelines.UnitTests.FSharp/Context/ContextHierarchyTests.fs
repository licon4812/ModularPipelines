namespace ModularPipelines.UnitTests.FSharp.Context

open ModularPipelines.UnitTests.Context
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ContextHierarchyTests() =
    inherit ModularPipelines.UnitTests.Context.ContextHierarchyTests()

    [<Test>]
    member this.IModuleContext_ShouldInheritFromIPipelineContext() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.ContextHierarchyTests> "IModuleContext_ShouldInheritFromIPipelineContext" None

    [<Test>]
    member this.IPipelineHookContext_ShouldInheritFromIPipelineContext() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.ContextHierarchyTests> "IPipelineHookContext_ShouldInheritFromIPipelineContext" None

    [<Test>]
    member this.IPipelineContext_ShouldHaveExpectedDomainProperties() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.ContextHierarchyTests> "IPipelineContext_ShouldHaveExpectedDomainProperties" None

    [<Test>]
    member this.IModuleContext_ShouldHaveGetModuleMethods() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.ContextHierarchyTests> "IModuleContext_ShouldHaveGetModuleMethods" None

    [<Test>]
    member this.IModuleContext_ShouldHaveSubModuleMethods() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Context.ContextHierarchyTests> "IModuleContext_ShouldHaveSubModuleMethods" None
