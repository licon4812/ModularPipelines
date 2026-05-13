namespace ModularPipelines.UnitTests.FSharp.Commands

open ModularPipelines.UnitTests.Commands
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type CommandParserTests() =
    inherit ModularPipelines.UnitTests.Commands.CommandParserTests()

    [<Test>]
    member this.Empty_Options_Parse_As_Expected() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "Empty_Options_Parse_As_Expected" None

    [<Test>]
    member this.KeyValues_Parse_As_Expected() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "KeyValues_Parse_As_Expected" None

    [<Test>]
    member this.Boolean_Switch_Parse_As_Expected_When_True() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "Boolean_Switch_Parse_As_Expected_When_True" None

    [<Test>]
    member this.Boolean_Switch_Parse_As_Expected_When_Not_True_Arguments1() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "Boolean_Switch_Parse_As_Expected_When_Not_True" (Some 0)

    [<Test>]
    member this.Boolean_Switch_Parse_As_Expected_When_Not_True_Arguments2() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "Boolean_Switch_Parse_As_Expected_When_Not_True" (Some 1)

    [<Test>]
    member this.String_Array_Switch_Parse_As_Expected() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "String_Array_Switch_Parse_As_Expected" None

    [<Test>]
    member this.String_Switch_Parse_As_Expected() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "String_Switch_Parse_As_Expected" None

    [<Test>]
    member this.Int_Switch_Parse_As_Expected() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "Int_Switch_Parse_As_Expected" None

    [<Test>]
    member this.Enum_Value_Switch_Parse_As_Expected() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "Enum_Value_Switch_Parse_As_Expected" None

    [<Test>]
    member this.Positional_Parameter_Before_Switches_Parse_As_Expected() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "Positional_Parameter_Before_Switches_Parse_As_Expected" None

    [<Test>]
    member this.Positional_Parameter_After_Switches_Parse_As_Expected() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "Positional_Parameter_After_Switches_Parse_As_Expected" None

    [<Test>]
    member this.Multiple_Positional_Arguments_With_Interleaved_Command() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "Multiple_Positional_Arguments_With_Interleaved_Command" None

    [<Test>]
    member this.Single_Positional_Argument_Immediately_After_Command() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "Single_Positional_Argument_Immediately_After_Command" None

    [<Test>]
    member this.DotNet_Nuget_Delete_With_Two_Positional_Arguments() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "DotNet_Nuget_Delete_With_Two_Positional_Arguments" None

    [<Test>]
    member this.DotNet_Nuget_Delete_With_Source_Option() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "DotNet_Nuget_Delete_With_Source_Option" None

    [<Test>]
    member this.DotNet_Nuget_Delete_With_ApiKey_Option() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Commands.CommandParserTests> "DotNet_Nuget_Delete_With_ApiKey_Option" None
