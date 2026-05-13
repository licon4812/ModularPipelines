namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type EnvironmentContextTests() =
    inherit ModularPipelines.UnitTests.Helpers.EnvironmentContextTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.EnvironmentContextTests> "Can_Read_Environment_Variables" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.EnvironmentContextTests> "Can_List_Environment_Variables" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.EnvironmentContextTests> "Can_Set_Environment_Variables" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.EnvironmentContextTests> "Can_Add_To_Path" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Helpers.EnvironmentContextTests> "Assert_Values_Populated" 0 None

