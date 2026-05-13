namespace ModularPipelines.UnitTests.FSharp.FileSystem

open ModularPipelines.UnitTests.FileSystem
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type PathHelpersTests() =
    inherit ModularPipelines.UnitTests.FileSystem.PathHelpersTests()

    [<Test>]
    member this.Get_Directory() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.PathHelpersTests> "Get_Directory" None

    [<Test>]
    member this.File_Path_Type() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.PathHelpersTests> "File_Path_Type" None

    [<Test>]
    member this.File_Path_Type2() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.PathHelpersTests> "File_Path_Type2" None

    [<Test>]
    member this.Directory_Path_Type() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.PathHelpersTests> "Directory_Path_Type" None

    [<Test>]
    member this.Directory_Path_Type2() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.PathHelpersTests> "Directory_Path_Type2" None

    [<Test>]
    member this.Directory_Path_Type_With_Trailing_Separator() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.PathHelpersTests> "Directory_Path_Type_With_Trailing_Separator" None

    [<Test>]
    member this.Directory_Path_Type_With_Dots_And_Trailing_Separator() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.PathHelpersTests> "Directory_Path_Type_With_Dots_And_Trailing_Separator" None

    [<Test>]
    member this.EndsWithDirectorySeparator_Returns_True_For_Trailing_Separator() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.PathHelpersTests> "EndsWithDirectorySeparator_Returns_True_For_Trailing_Separator" None

    [<Test>]
    member this.EndsWithDirectorySeparator_Returns_True_For_Alt_Separator() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.PathHelpersTests> "EndsWithDirectorySeparator_Returns_True_For_Alt_Separator" None

    [<Test>]
    member this.EndsWithDirectorySeparator_Returns_False_For_No_Separator() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.PathHelpersTests> "EndsWithDirectorySeparator_Returns_False_For_No_Separator" None

    [<Test>]
    member this.EndsWithDirectorySeparator_Returns_False_For_Empty_String() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.PathHelpersTests> "EndsWithDirectorySeparator_Returns_False_For_Empty_String" None

    [<Test>]
    member this.EndsWithDirectorySeparator_Returns_False_For_Null() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.FileSystem.PathHelpersTests> "EndsWithDirectorySeparator_Returns_False_For_Null" None
