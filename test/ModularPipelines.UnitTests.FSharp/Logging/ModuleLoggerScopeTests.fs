namespace ModularPipelines.UnitTests.FSharp.Logging

open ModularPipelines.UnitTests.Logging
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type ModuleLoggerScopeTests() =
    inherit ModularPipelines.UnitTests.Logging.ModuleLoggerScopeTests()

    [<Test>]
    member this.ModuleLoggerScope_SetsContext_WhenCreated() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.ModuleLoggerScopeTests> "ModuleLoggerScope_SetsContext_WhenCreated" None

    [<Test>]
    member this.ModuleLoggerScope_RestoresNullContext_AfterDispose() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.ModuleLoggerScopeTests> "ModuleLoggerScope_RestoresNullContext_AfterDispose" None

    [<Test>]
    member this.ModuleLoggerScope_RestoresPreviousContext_AfterDispose() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.ModuleLoggerScopeTests> "ModuleLoggerScope_RestoresPreviousContext_AfterDispose" None

    [<Test>]
    member this.ModuleLoggerScope_NestedScopes_RestoreCorrectly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.ModuleLoggerScopeTests> "ModuleLoggerScope_NestedScopes_RestoreCorrectly" None

    [<Test>]
    member this.ModuleLoggerScope_RestoresContext_EvenAfterException() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.ModuleLoggerScopeTests> "ModuleLoggerScope_RestoresContext_EvenAfterException" None

    [<Test>]
    member this.ModuleLoggerScope_DoubleDispose_IsIdempotent() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.ModuleLoggerScopeTests> "ModuleLoggerScope_DoubleDispose_IsIdempotent" None

    [<Test>]
    member this.ModuleLoggerScope_AsyncExecution_MaintainsContext() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.ModuleLoggerScopeTests> "ModuleLoggerScope_AsyncExecution_MaintainsContext" None
