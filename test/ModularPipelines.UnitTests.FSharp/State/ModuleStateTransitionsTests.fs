namespace ModularPipelines.UnitTests.FSharp.State

open System
open System.Collections.Immutable
open System.Threading
open ModularPipelines.Engine.State
open ModularPipelines.Enums
open ModularPipelines.Models
open ModularPipelines.Modules
open ModularPipelines.TestHelpers
open TUnit.Assertions
open TUnit.Assertions.Extensions
open TUnit.Assertions.FSharp.Operations
open TUnit.Core

type private TransitionTestModuleResult() =
    interface IModuleResult with
        member _.ModuleName = "TestModule"
        member _.ModuleDuration = TimeSpan.Zero
        member _.ModuleStart = DateTimeOffset.UtcNow
        member _.ModuleEnd = DateTimeOffset.UtcNow
        member _.ModuleStatus = Status.Successful
        member _.ModuleResultType = ModuleResultType.Success
        member _.IsSuccess = true
        member _.IsFailure = false
        member _.IsSkipped = false
        member _.ValueOrDefault = null
        member _.ExceptionOrDefault = null
        member _.SkipDecisionOrDefault = Unchecked.defaultof<_>

type ModuleStateTransitionsTests() =
    inherit TestBase()

    let createSnapshot phase =
        ModuleStateSnapshot(
            ModuleType = typeof<string>,
            Module = Unchecked.defaultof<IModule>,
            Phase = phase,
            RequiresSequentialExecution = false,
            RequiredLockKeys = Array.empty,
            Priority = ModulePriority.Normal,
            ExecutionType = ExecutionType.Default,
            CompletionSource = System.Threading.Tasks.TaskCompletionSource<IModule>()
        )

    let pendingNoDeps =
        ModuleExecutionPhase.Pending(
            UnresolvedDependencies = ImmutableHashSet<Type>.Empty,
            DependentModules = ImmutableList<Type>.Empty
        )

    let pendingWithDep =
        ModuleExecutionPhase.Pending(
            UnresolvedDependencies = ImmutableHashSet.Create(typeof<string>),
            DependentModules = ImmutableList<Type>.Empty
        )

    let now = DateTimeOffset.UtcNow

    let queued =
        ModuleExecutionPhase.Queued(
            DependentModules = ImmutableList<Type>.Empty,
            QueuedAt = now,
            ReadyAt = now
        )

    let running =
        ModuleExecutionPhase.Running(
            DependentModules = ImmutableList<Type>.Empty,
            StartedAt = now,
            QueuedAt = now.AddSeconds(-1.0),
            CancellationSource = new CancellationTokenSource()
        )

    [<Test>]
    member _.Pending_WithNoDependencies_IsReadyToQueue() = async {
        do! check(Assert.That(pendingNoDeps.IsReadyToQueue).IsTrue())
    }

    [<Test>]
    member _.Pending_WithDependencies_IsNotReadyToQueue() = async {
        do! check(Assert.That(pendingWithDep.IsReadyToQueue).IsFalse())
    }

    [<Test>]
    member _.Pending_HasNotYetStartedStatus() = async {
        let snapshot = createSnapshot pendingNoDeps

        do! check(Assert.That(snapshot.Status).IsEqualTo(Status.NotYetStarted))
    }

    [<Test>]
    member _.Running_HasProcessingStatus() = async {
        let snapshot = createSnapshot running

        do! check(Assert.That(snapshot.Status).IsEqualTo(Status.Processing))
    }

    [<Test>]
    member _.Completed_HasSuccessfulStatus() = async {
        let completed =
            ModuleExecutionPhase.Completed(
                DependentModules = ImmutableList<Type>.Empty,
                StartedAt = now.AddSeconds(-2.0),
                CompletedAt = now,
                Result = TransitionTestModuleResult()
            )

        let snapshot = createSnapshot completed

        do! check(Assert.That(snapshot.Status).IsEqualTo(Status.Successful))
    }

    [<Test>]
    member _.Failed_HasFailedStatus() = async {
        let failed =
            ModuleExecutionPhase.Failed(
                DependentModules = ImmutableList<Type>.Empty,
                StartedAt = now.AddSeconds(-2.0),
                FailedAt = now,
                Exception = Exception("test"),
                Result = TransitionTestModuleResult()
            )

        let snapshot = createSnapshot failed

        do! check(Assert.That(snapshot.Status).IsEqualTo(Status.Failed))
    }

    [<Test>]
    member _.Skipped_HasSkippedStatus() = async {
        let skipped =
            ModuleExecutionPhase.Skipped(
                DependentModules = ImmutableList<Type>.Empty,
                SkippedAt = now,
                SkipDecision = SkipDecision.Skip("test"),
                Result = TransitionTestModuleResult()
            )

        let snapshot = createSnapshot skipped

        do! check(Assert.That(snapshot.IsSuccessful).IsFalse())
    }

    [<Test>]
    member _.Queued_HasNotYetStartedStatus() = async {
        let snapshot = createSnapshot queued

        do! check(Assert.That(snapshot.Status).IsEqualTo(Status.NotYetStarted))
    }

    [<Test>]
    member _.Completed_IsSuccessful() = async {
        let completed =
            ModuleExecutionPhase.Completed(
                DependentModules = ImmutableList<Type>.Empty,
                StartedAt = now.AddSeconds(-2.0),
                CompletedAt = now,
                Result = TransitionTestModuleResult()
            )

        let snapshot = createSnapshot completed

        do! check(Assert.That(snapshot.IsSuccessful).IsTrue())
    }
