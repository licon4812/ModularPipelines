namespace ModularPipelines.UnitTests.FSharp.Context

open ModularPipelines.UnitTests.Context
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ContextHierarchyTests() =
    inherit ModularPipelines.UnitTests.Context.ContextHierarchyTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.ContextHierarchyTests> "IModuleContext_ShouldInheritFromIPipelineContext" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.ContextHierarchyTests> "IPipelineHookContext_ShouldInheritFromIPipelineContext" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.ContextHierarchyTests> "IPipelineContext_ShouldHaveExpectedDomainProperties" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.ContextHierarchyTests> "IModuleContext_ShouldHaveGetModuleMethods" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Context.ContextHierarchyTests> "IModuleContext_ShouldHaveSubModuleMethods" 0 None

