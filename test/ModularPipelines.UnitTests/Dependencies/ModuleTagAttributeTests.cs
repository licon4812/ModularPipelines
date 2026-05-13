using System.Reflection;
using ModularPipelines.Attributes;
using ModularPipelines.TestHelpers;

namespace ModularPipelines.UnitTests.Dependencies;

public class ModuleTagAttributeTests : TestBase
{
    public async Task Constructor_WithValidTag_SetsTagProperty()
    {
        var attr = new ModuleTagAttribute("database");
        await Assert.That(attr.Tag).IsEqualTo("database");
    }

    public async Task Constructor_WithNullTag_ThrowsArgumentException()
    {
        await Assert.That(() => new ModuleTagAttribute(null!))
            .ThrowsException()
            .And.IsTypeOf<ArgumentException>();
    }

    public async Task Constructor_WithEmptyTag_ThrowsArgumentException()
    {
        await Assert.That(() => new ModuleTagAttribute(""))
            .ThrowsException()
            .And.IsTypeOf<ArgumentException>();
    }

    public async Task Constructor_WithWhitespaceTag_ThrowsArgumentException()
    {
        await Assert.That(() => new ModuleTagAttribute("   "))
            .ThrowsException()
            .And.IsTypeOf<ArgumentException>();
    }

    public async Task Attribute_AllowsMultiple()
    {
        var usage = typeof(ModuleTagAttribute).GetCustomAttribute<AttributeUsageAttribute>();
        await Assert.That(usage!.AllowMultiple).IsTrue();
    }

    public async Task Attribute_IsInheritable()
    {
        var usage = typeof(ModuleTagAttribute).GetCustomAttribute<AttributeUsageAttribute>();
        await Assert.That(usage!.Inherited).IsTrue();
    }
}
