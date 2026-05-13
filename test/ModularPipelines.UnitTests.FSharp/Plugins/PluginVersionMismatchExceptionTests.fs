namespace ModularPipelines.UnitTests.FSharp.Plugins

open ModularPipelines.UnitTests.Plugins
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type PluginVersionMismatchExceptionTests() =
    inherit ModularPipelines.UnitTests.Plugins.PluginVersionMismatchExceptionTests()

    [<Test>]
    member this.Message_ContainsPluginName() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.PluginVersionMismatchExceptionTests> "Message_ContainsPluginName" None

    [<Test>]
    member this.Message_ContainsRequiredVersion() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.PluginVersionMismatchExceptionTests> "Message_ContainsRequiredVersion" None

    [<Test>]
    member this.Message_ContainsActualVersion() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.PluginVersionMismatchExceptionTests> "Message_ContainsActualVersion" None

    [<Test>]
    member this.Message_HandlesNullVersion() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.PluginVersionMismatchExceptionTests> "Message_HandlesNullVersion" None

    [<Test>]
    member this.Properties_AreSetCorrectly() =
        CSharpTestWrapper.invokeTest this typeof<ModularPipelines.UnitTests.Plugins.PluginVersionMismatchExceptionTests> "Properties_AreSetCorrectly" None
