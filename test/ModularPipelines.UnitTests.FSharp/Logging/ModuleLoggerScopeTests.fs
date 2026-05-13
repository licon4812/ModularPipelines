namespace ModularPipelines.UnitTests.FSharp.Logging

open ModularPipelines.UnitTests.Logging
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleLoggerScopeTests() =
    inherit ModularPipelines.UnitTests.Logging.ModuleLoggerScopeTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.ModuleLoggerScopeTests> "ModuleLoggerScope_SetsContext_WhenCreated" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.ModuleLoggerScopeTests> "ModuleLoggerScope_RestoresNullContext_AfterDispose" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.ModuleLoggerScopeTests> "ModuleLoggerScope_RestoresPreviousContext_AfterDispose" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.ModuleLoggerScopeTests> "ModuleLoggerScope_NestedScopes_RestoreCorrectly" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.ModuleLoggerScopeTests> "ModuleLoggerScope_RestoresContext_EvenAfterException" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.ModuleLoggerScopeTests> "ModuleLoggerScope_DoubleDispose_IsIdempotent" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.ModuleLoggerScopeTests> "ModuleLoggerScope_AsyncExecution_MaintainsContext" 0 None

