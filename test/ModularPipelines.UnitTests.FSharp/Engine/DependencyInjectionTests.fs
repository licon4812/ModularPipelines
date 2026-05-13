namespace ModularPipelines.UnitTests.FSharp.Engine

open ModularPipelines.UnitTests.Engine
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DependencyInjectionTests() =
    inherit ModularPipelines.UnitTests.Engine.DependencyInjectionTests()

    [<Test>]
    member this.AllDependenciesCanBeBuilt() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Engine.DependencyInjectionTests> "AllDependenciesCanBeBuilt" None
