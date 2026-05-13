namespace ModularPipelines.UnitTests.FSharp.Dependencies

open ModularPipelines.UnitTests.Dependencies
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type DynamicDependencyDeclarationTests() =
    inherit ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests()

    [<Test>]
    member this.Programmatic_Required_Dependency_Works_When_Registered() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Programmatic_Required_Dependency_Works_When_Registered" None

    [<Test>]
    member this.Programmatic_Required_Dependency_Throws_When_Not_Registered() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Programmatic_Required_Dependency_Throws_When_Not_Registered" None

    [<Test>]
    member this.Programmatic_Type_Dependency_Works() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Programmatic_Type_Dependency_Works" None

    [<Test>]
    member this.Optional_Dependency_Works_When_Registered() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Optional_Dependency_Works_When_Registered" None

    [<Test>]
    member this.Optional_Dependency_Does_Not_Fail_When_Not_Registered() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Optional_Dependency_Does_Not_Fail_When_Not_Registered" None

    [<Test>]
    member this.Conditional_Dependency_Works_When_Condition_True_And_Registered() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Conditional_Dependency_Works_When_Condition_True_And_Registered" None

    [<Test>]
    member this.Conditional_Dependency_Throws_When_Condition_True_And_Not_Registered() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Conditional_Dependency_Throws_When_Condition_True_And_Not_Registered" None

    [<Test>]
    member this.Conditional_Dependency_Not_Added_When_Condition_False() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Conditional_Dependency_Not_Added_When_Condition_False" None

    [<Test>]
    [<TUnit.Core.NotInParallel(Order = 1)>]
    member this.Conditional_Predicate_Dependency_Works_When_Predicate_Returns_True() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Conditional_Predicate_Dependency_Works_When_Predicate_Returns_True" None

    [<Test>]
    [<TUnit.Core.NotInParallel(Order = 2)>]
    member this.Conditional_Predicate_Dependency_Not_Added_When_Predicate_Returns_False() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Conditional_Predicate_Dependency_Not_Added_When_Predicate_Returns_False" None

    [<Test>]
    member this.Lazy_Dependency_Does_Not_Fail_When_Not_Registered() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Lazy_Dependency_Does_Not_Fail_When_Not_Registered" None

    [<Test>]
    member this.Lazy_Dependency_Works_When_Registered() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Lazy_Dependency_Works_When_Registered" None

    [<Test>]
    member this.Combined_Attribute_And_Programmatic_Dependencies_Work() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Combined_Attribute_And_Programmatic_Dependencies_Work" None

    [<Test>]
    member this.Combined_Dependencies_Work_With_Only_Attribute_Dependency_Registered() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Combined_Dependencies_Work_With_Only_Attribute_Dependency_Registered" None

    [<Test>]
    member this.Chained_Dependency_Declarations_Work() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Chained_Dependency_Declarations_Work" None

    [<Test>]
    member this.Chained_Dependency_Declarations_Work_With_Only_Required_Registered() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "Chained_Dependency_Declarations_Work_With_Only_Required_Registered" None

    [<Test>]
    member this.DependencyDeclaration_DependsOn_Returns_Same_Instance_For_Chaining() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "DependencyDeclaration_DependsOn_Returns_Same_Instance_For_Chaining" None

    [<Test>]
    member this.DependencyDeclaration_DependsOnOptional_Returns_Same_Instance_For_Chaining() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "DependencyDeclaration_DependsOnOptional_Returns_Same_Instance_For_Chaining" None

    [<Test>]
    member this.DependencyDeclaration_DependsOnIf_Returns_Same_Instance_For_Chaining() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "DependencyDeclaration_DependsOnIf_Returns_Same_Instance_For_Chaining" None

    [<Test>]
    member this.DependencyDeclaration_DependsOnLazy_Returns_Same_Instance_For_Chaining() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "DependencyDeclaration_DependsOnLazy_Returns_Same_Instance_For_Chaining" None

    [<Test>]
    member this.DependencyDeclaration_Throws_For_Non_Module_Type() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "DependencyDeclaration_Throws_For_Non_Module_Type" None

    [<Test>]
    member this.DependencyDeclaration_Required_Has_Correct_DependencyType() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "DependencyDeclaration_Required_Has_Correct_DependencyType" None

    [<Test>]
    member this.DependencyDeclaration_Optional_Has_Correct_DependencyType() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "DependencyDeclaration_Optional_Has_Correct_DependencyType" None

    [<Test>]
    member this.DependencyDeclaration_Lazy_Has_Correct_DependencyType() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "DependencyDeclaration_Lazy_Has_Correct_DependencyType" None

    [<Test>]
    member this.DependencyDeclaration_Conditional_Has_Correct_DependencyType() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "DependencyDeclaration_Conditional_Has_Correct_DependencyType" None

    [<Test>]
    member this.DependencyDeclaration_Conditional_False_Does_Not_Add_Dependency() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Dependencies.DynamicDependencyDeclarationTests> "DependencyDeclaration_Conditional_False_Does_Not_Add_Dependency" None
