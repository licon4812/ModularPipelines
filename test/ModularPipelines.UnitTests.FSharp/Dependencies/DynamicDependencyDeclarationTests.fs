namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DynamicDependencyDeclarationTests() =
    inherit ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Programmatic_Required_Dependency_Works_When_Registered" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Programmatic_Required_Dependency_Throws_When_Not_Registered" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Programmatic_Type_Dependency_Works" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Optional_Dependency_Works_When_Registered" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Optional_Dependency_Does_Not_Fail_When_Not_Registered" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Conditional_Dependency_Works_When_Condition_True_And_Registered" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Conditional_Dependency_Throws_When_Condition_True_And_Not_Registered" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Conditional_Dependency_Not_Added_When_Condition_False" 0 None

    [<Test>]
    [<TUnit.Core.NotInParallel(Order = 1)>]
    member this.Test_9() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Conditional_Predicate_Dependency_Works_When_Predicate_Returns_True" 0 None

    [<Test>]
    [<TUnit.Core.NotInParallel(Order = 2)>]
    member this.Test_10() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Conditional_Predicate_Dependency_Not_Added_When_Predicate_Returns_False" 0 None

    [<Test>]
    member this.Test_11() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Lazy_Dependency_Does_Not_Fail_When_Not_Registered" 0 None

    [<Test>]
    member this.Test_12() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Lazy_Dependency_Works_When_Registered" 0 None

    [<Test>]
    member this.Test_13() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Combined_Attribute_And_Programmatic_Dependencies_Work" 0 None

    [<Test>]
    member this.Test_14() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Combined_Dependencies_Work_With_Only_Attribute_Dependency_Registered" 0 None

    [<Test>]
    member this.Test_15() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Chained_Dependency_Declarations_Work" 0 None

    [<Test>]
    member this.Test_16() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Chained_Dependency_Declarations_Work_With_Only_Required_Registered" 0 None

    [<Test>]
    member this.Test_17() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "DependencyDeclaration_DependsOn_Returns_Same_Instance_For_Chaining" 0 None

    [<Test>]
    member this.Test_18() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "DependencyDeclaration_DependsOnOptional_Returns_Same_Instance_For_Chaining" 0 None

    [<Test>]
    member this.Test_19() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "DependencyDeclaration_DependsOnIf_Returns_Same_Instance_For_Chaining" 0 None

    [<Test>]
    member this.Test_20() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "DependencyDeclaration_DependsOnLazy_Returns_Same_Instance_For_Chaining" 0 None

    [<Test>]
    member this.Test_21() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "DependencyDeclaration_Throws_For_Non_Module_Type" 0 None

    [<Test>]
    member this.Test_22() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "DependencyDeclaration_Required_Has_Correct_DependencyType" 0 None

    [<Test>]
    member this.Test_23() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "DependencyDeclaration_Optional_Has_Correct_DependencyType" 0 None

    [<Test>]
    member this.Test_24() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "DependencyDeclaration_Lazy_Has_Correct_DependencyType" 0 None

    [<Test>]
    member this.Test_25() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "DependencyDeclaration_Conditional_Has_Correct_DependencyType" 0 None

    [<Test>]
    member this.Test_26() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "DependencyDeclaration_Conditional_False_Does_Not_Add_Dependency" 0 None

