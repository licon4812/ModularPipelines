using System.Reflection;
using ModularPipelines.Attributes;
using ModularPipelines.TestHelpers;

namespace ModularPipelines.UnitTests.Dependencies;

public class ModuleCategoryAttributeTests : TestBase
{
    public async Task Constructor_WithValidCategory_SetsCategoryProperty()
    {
        var attr = new ModuleCategoryAttribute("infrastructure");
        await Assert.That(attr.Category).IsEqualTo("infrastructure");
    }

    public async Task Constructor_WithNullCategory_ThrowsArgumentException()
    {
        await Assert.That(() => new ModuleCategoryAttribute(null!))
            .ThrowsException()
            .And.IsTypeOf<ArgumentException>();
    }

    public async Task Constructor_WithEmptyCategory_ThrowsArgumentException()
    {
        await Assert.That(() => new ModuleCategoryAttribute(""))
            .ThrowsException()
            .And.IsTypeOf<ArgumentException>();
    }

    public async Task Attribute_DoesNotAllowMultiple()
    {
        var usage = typeof(ModuleCategoryAttribute).GetCustomAttribute<AttributeUsageAttribute>();
        await Assert.That(usage!.AllowMultiple).IsFalse();
    }

    public async Task Attribute_IsInheritable()
    {
        var usage = typeof(ModuleCategoryAttribute).GetCustomAttribute<AttributeUsageAttribute>();
        await Assert.That(usage!.Inherited).IsTrue();
    }
}
