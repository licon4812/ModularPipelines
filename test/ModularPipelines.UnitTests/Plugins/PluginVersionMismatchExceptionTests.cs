using ModularPipelines.Exceptions;

namespace ModularPipelines.UnitTests.Plugins;

public class PluginVersionMismatchExceptionTests
{
    public async Task Message_ContainsPluginName()
    {
        var ex = new PluginVersionMismatchException(
            "ModularPipelines.CustomTool",
            4,
            new Version(5, 2, 0));

        await Assert.That(ex.Message).Contains("ModularPipelines.CustomTool");
    }

    public async Task Message_ContainsRequiredVersion()
    {
        var ex = new PluginVersionMismatchException(
            "TestPlugin",
            4,
            new Version(5, 2, 0));

        await Assert.That(ex.Message).Contains("4.x");
    }

    public async Task Message_ContainsActualVersion()
    {
        var ex = new PluginVersionMismatchException(
            "TestPlugin",
            4,
            new Version(5, 2, 0));

        await Assert.That(ex.Message).Contains("5.2.0");
    }

    public async Task Message_HandlesNullVersion()
    {
        var ex = new PluginVersionMismatchException(
            "TestPlugin",
            4,
            null);

        await Assert.That(ex.Message).Contains("unknown");
    }

    public async Task Properties_AreSetCorrectly()
    {
        var version = new Version(5, 2, 0);
        var ex = new PluginVersionMismatchException("TestPlugin", 4, version);

        using (Assert.Multiple())
        {
            await Assert.That(ex.PluginName).IsEqualTo("TestPlugin");
            await Assert.That(ex.RequiredMajorVersion).IsEqualTo(4);
            await Assert.That(ex.ActualCoreVersion).IsEqualTo(version);
        }
    }
}
