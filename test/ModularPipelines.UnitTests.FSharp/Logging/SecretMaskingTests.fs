namespace ModularPipelines.UnitTests.FSharp.Logging

open ModularPipelines.UnitTests.Logging
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type SecretMaskingTests() =
    inherit ModularPipelines.UnitTests.Logging.SecretMaskingTests()

    [<Test>]
    member this.CaseSensitive_DoesNotMaskDifferentCase() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "CaseSensitive_DoesNotMaskDifferentCase" None

    [<Test>]
    member this.CaseInsensitive_MasksAllCaseVariants() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "CaseInsensitive_MasksAllCaseVariants" None

    [<Test>]
    member this.MinimumLength_ShortSecretsAreNotMasked_WhenConfigured() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "MinimumLength_ShortSecretsAreNotMasked_WhenConfigured" None

    [<Test>]
    member this.MinimumLength_SecretsAtMinimumAreMasked() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "MinimumLength_SecretsAtMinimumAreMasked" None

    [<Test>]
    member this.MinimumLength_DefaultMasksAllSecrets() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "MinimumLength_DefaultMasksAllSecrets" None

    [<Test>]
    member this.CustomMaskValue_UsesProvidedMask() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "CustomMaskValue_UsesProvidedMask" None

    [<Test>]
    member this.DynamicSecretRegistration_MasksDynamicallyAddedSecrets() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "DynamicSecretRegistration_MasksDynamicallyAddedSecrets" None

    [<Test>]
    member this.MultipleSecrets_AllAreMasked() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "MultipleSecrets_AllAreMasked" None

    [<Test>]
    member this.OverlappingSecrets_LongerSecretTakesPrecedence() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "OverlappingSecrets_LongerSecretTakesPrecedence" None

    [<Test>]
    member this.EmptyAndWhitespaceSecrets_AreIgnored() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "EmptyAndWhitespaceSecrets_AreIgnored" None

    [<Test>]
    member this.SpecialCharactersInSecrets_AreMaskedCorrectly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "SpecialCharactersInSecrets_AreMaskedCorrectly" None

    [<Test>]
    member this.UnicodeSecrets_AreMaskedCorrectly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Logging.SecretMaskingTests> "UnicodeSecrets_AreMaskedCorrectly" None
