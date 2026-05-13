namespace ModularPipelines.UnitTests.FSharp.Commands

open ModularPipelines.UnitTests.Commands
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type CommandParserTests() =
    inherit ModularPipelines.UnitTests.Commands.CommandParserTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "Empty_Options_Parse_As_Expected" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "KeyValues_Parse_As_Expected" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "Boolean_Switch_Parse_As_Expected_When_True" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "Boolean_Switch_Parse_As_Expected_When_Not_True" 0 (Some 0)

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "Boolean_Switch_Parse_As_Expected_When_Not_True" 0 (Some 1)

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "String_Array_Switch_Parse_As_Expected" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "String_Switch_Parse_As_Expected" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "Int_Switch_Parse_As_Expected" 0 None

    [<Test>]
    member this.Test_9() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "Enum_Value_Switch_Parse_As_Expected" 0 None

    [<Test>]
    member this.Test_10() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "Positional_Parameter_Before_Switches_Parse_As_Expected" 0 None

    [<Test>]
    member this.Test_11() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "Positional_Parameter_After_Switches_Parse_As_Expected" 0 None

    [<Test>]
    member this.Test_12() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "Multiple_Positional_Arguments_With_Interleaved_Command" 0 None

    [<Test>]
    member this.Test_13() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "Single_Positional_Argument_Immediately_After_Command" 0 None

    [<Test>]
    member this.Test_14() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "DotNet_Nuget_Delete_With_Two_Positional_Arguments" 0 None

    [<Test>]
    member this.Test_15() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "DotNet_Nuget_Delete_With_Source_Option" 0 None

    [<Test>]
    member this.Test_16() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "DotNet_Nuget_Delete_With_ApiKey_Option" 0 None

