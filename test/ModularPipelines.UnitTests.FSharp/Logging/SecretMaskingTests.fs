namespace ModularPipelines.UnitTests.FSharp.Logging

open ModularPipelines.UnitTests.Logging
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type SecretMaskingTests() =
    inherit ModularPipelines.UnitTests.Logging.SecretMaskingTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "CaseSensitive_DoesNotMaskDifferentCase" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "CaseInsensitive_MasksAllCaseVariants" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "MinimumLength_ShortSecretsAreNotMasked_WhenConfigured" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "MinimumLength_SecretsAtMinimumAreMasked" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "MinimumLength_DefaultMasksAllSecrets" 0 None

    [<Test>]
    member this.Test_6() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "CustomMaskValue_UsesProvidedMask" 0 None

    [<Test>]
    member this.Test_7() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "DynamicSecretRegistration_MasksDynamicallyAddedSecrets" 0 None

    [<Test>]
    member this.Test_8() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "MultipleSecrets_AllAreMasked" 0 None

    [<Test>]
    member this.Test_9() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "OverlappingSecrets_LongerSecretTakesPrecedence" 0 None

    [<Test>]
    member this.Test_10() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "EmptyAndWhitespaceSecrets_AreIgnored" 0 None

    [<Test>]
    member this.Test_11() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "SpecialCharactersInSecrets_AreMaskedCorrectly" 0 None

    [<Test>]
    member this.Test_12() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "UnicodeSecrets_AreMaskedCorrectly" 0 None

