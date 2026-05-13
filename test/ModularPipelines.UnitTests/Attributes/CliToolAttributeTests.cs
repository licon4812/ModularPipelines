using ModularPipelines.Attributes;
using ModularPipelines.Options;
using System.Reflection;

namespace ModularPipelines.UnitTests.Attributes;

public class CliToolAttributeTests
{
    public async Task CliToolAttribute_StoresToolName()
    {
        var attribute = new CliToolAttribute("git");

        await Assert.That(attribute.Tool).IsEqualTo("git");
    }

    public async Task CliToolAttribute_CanBeAppliedToClass()
    {
        var attribute = typeof(TestGitOptions).GetCustomAttribute<CliToolAttribute>();

        await Assert.That(attribute).IsNotNull();
        await Assert.That(attribute!.Tool).IsEqualTo("git");
    }

    public async Task CliToolAttribute_ThrowsOnNullOrWhitespace()
    {
        await Assert.That(() => new CliToolAttribute(null!)).Throws<ArgumentException>();
        await Assert.That(() => new CliToolAttribute("")).Throws<ArgumentException>();
        await Assert.That(() => new CliToolAttribute("   ")).Throws<ArgumentException>();
    }

    public async Task CliToolAttribute_IsInheritedByDerivedClasses()
    {
        var attribute = typeof(TestGitCommitOptions).GetCustomAttribute<CliToolAttribute>(inherit: true);

        await Assert.That(attribute).IsNotNull();
        await Assert.That(attribute!.Tool).IsEqualTo("git");
    }

    [CliTool("git")]
    private abstract record TestGitOptions : CommandLineToolOptions;

    private record TestGitCommitOptions : TestGitOptions;

    [CliTool("test")]
    private record TestOptionsWithAttribute : CommandLineToolOptions;
}
