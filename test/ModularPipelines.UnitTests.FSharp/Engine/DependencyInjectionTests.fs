namespace ModularPipelines.UnitTests.FSharp.Engine

open ModularPipelines.UnitTests.Engine
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DependencyInjectionTests() =
    inherit ModularPipelines.UnitTests.Engine.DependencyInjectionTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Engine.DependencyInjectionTests> "AllDependenciesCanBeBuilt" 0 None

