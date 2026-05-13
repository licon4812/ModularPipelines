namespace ModularPipelines.UnitTests.Attributes

open System.Threading
open System.Threading.Tasks
open ModularPipelines.Context
open ModularPipelines.Engine.Dependencies
open ModularPipelines.Modules
open TUnit.Assertions
open TUnit.Assertions.FSharp.Operations
open TUnit.Core

module ModuleDependencyRegistryTests =
    type private ModuleA() =
        inherit Module<string>()
        override _.ExecuteAsync(_: IModuleContext, _: CancellationToken) =
            Task.FromResult<string>("A")

    type private ModuleB() =
        inherit Module<string>()
        override _.ExecuteAsync(_: IModuleContext, _: CancellationToken) =
            Task.FromResult<string>("B")

    type private ModuleC() =
        inherit Module<string>()
        override _.ExecuteAsync(_: IModuleContext, _: CancellationToken) =
            Task.FromResult<string>("C")

type ModuleDependencyRegistryTests() =
    [<Test>]
    member _.AddDynamicDependency_AddsDependency() = async {
        let registry = ModuleDependencyRegistry()
        registry.AddDynamicDependency(typeof<ModuleDependencyRegistryTests.ModuleA>, typeof<ModuleDependencyRegistryTests.ModuleB>)
        let dependencies = registry.GetDynamicDependencies(typeof<ModuleDependencyRegistryTests.ModuleA>)
        do! check(Assert.That(dependencies |> Seq.contains typeof<ModuleDependencyRegistryTests.ModuleB>).IsTrue())
    }

    [<Test>]
    member _.AddDynamicDependency_MultipleDependencies_AddsAll() = async {
        let registry = ModuleDependencyRegistry()
        registry.AddDynamicDependency(typeof<ModuleDependencyRegistryTests.ModuleA>, typeof<ModuleDependencyRegistryTests.ModuleB>)
        registry.AddDynamicDependency(typeof<ModuleDependencyRegistryTests.ModuleA>, typeof<ModuleDependencyRegistryTests.ModuleC>)
        let dependencies = registry.GetDynamicDependencies(typeof<ModuleDependencyRegistryTests.ModuleA>)
        do! check(Assert.That(dependencies |> Seq.length).IsEqualTo(2))
        do! check(Assert.That(dependencies |> Seq.contains typeof<ModuleDependencyRegistryTests.ModuleB>).IsTrue())
        do! check(Assert.That(dependencies |> Seq.contains typeof<ModuleDependencyRegistryTests.ModuleC>).IsTrue())
    }

    [<Test>]
    member _.RemoveDependency_RemovesDependency() = async {
        let registry = ModuleDependencyRegistry()
        registry.AddDynamicDependency(typeof<ModuleDependencyRegistryTests.ModuleA>, typeof<ModuleDependencyRegistryTests.ModuleB>)
        registry.RemoveDependency(typeof<ModuleDependencyRegistryTests.ModuleA>, typeof<ModuleDependencyRegistryTests.ModuleB>)
        let dependencies = registry.GetDynamicDependencies(typeof<ModuleDependencyRegistryTests.ModuleA>)
        do! check(Assert.That(dependencies).IsEmpty())
    }

    [<Test>]
    member _.GetDynamicDependencies_NoDependencies_ReturnsEmpty() = async {
        let registry = ModuleDependencyRegistry()
        let dependencies = registry.GetDynamicDependencies(typeof<ModuleDependencyRegistryTests.ModuleA>)
        do! check(Assert.That(dependencies).IsEmpty())
    }
