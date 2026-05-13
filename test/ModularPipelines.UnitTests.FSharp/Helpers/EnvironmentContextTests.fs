namespace ModularPipelines.UnitTests.FSharp.Helpers

open ModularPipelines.UnitTests.Helpers
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type EnvironmentContextTests() =
    inherit ModularPipelines.UnitTests.Helpers.EnvironmentContextTests()

    [<Test>]
    member this.Can_Read_Environment_Variables() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.EnvironmentContextTests> "Can_Read_Environment_Variables" None

    [<Test>]
    member this.Can_List_Environment_Variables() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.EnvironmentContextTests> "Can_List_Environment_Variables" None

    [<Test>]
    member this.Can_Set_Environment_Variables() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.EnvironmentContextTests> "Can_Set_Environment_Variables" None

    [<Test>]
    member this.Can_Add_To_Path() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.EnvironmentContextTests> "Can_Add_To_Path" None

    [<Test>]
    member this.Assert_Values_Populated() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Helpers.EnvironmentContextTests> "Assert_Values_Populated" None
