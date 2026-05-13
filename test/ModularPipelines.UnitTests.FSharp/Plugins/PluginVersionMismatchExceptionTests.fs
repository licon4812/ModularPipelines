namespace ModularPipelines.UnitTests.FSharp.Plugins

open ModularPipelines.UnitTests.Plugins
open ModularPipelines.UnitTests.FSharp
open TUnit.Core

type PluginVersionMismatchExceptionTests() =
    inherit ModularPipelines.UnitTests.Plugins.PluginVersionMismatchExceptionTests()

    [<Test>]
    member this.Test_1() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.PluginVersionMismatchExceptionTests> "Message_ContainsPluginName" 0 None

    [<Test>]
    member this.Test_2() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.PluginVersionMismatchExceptionTests> "Message_ContainsRequiredVersion" 0 None

    [<Test>]
    member this.Test_3() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.PluginVersionMismatchExceptionTests> "Message_ContainsActualVersion" 0 None

    [<Test>]
    member this.Test_4() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.PluginVersionMismatchExceptionTests> "Message_HandlesNullVersion" 0 None

    [<Test>]
    member this.Test_5() =
        CSharpTestWrapper.invokeTest (this :> obj) typeof<ModularPipelines.UnitTests.Plugins.PluginVersionMismatchExceptionTests> "Properties_AreSetCorrectly" 0 None

