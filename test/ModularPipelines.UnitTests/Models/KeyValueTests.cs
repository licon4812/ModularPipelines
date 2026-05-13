using ModularPipelines.Models;

namespace ModularPipelines.UnitTests.Models;

public class KeyValueTests
{
    public async Task ImplicitOperator1()
    {
        KeyValue keyValue = ("one", "two");

        using (Assert.Multiple())
        {
            await Assert.That(keyValue.Key).IsEqualTo("one");
            await Assert.That(keyValue.Value).IsEqualTo("two");
        }
    }

    public async Task ImplicitOperator2()
    {
        KeyValue keyValue = new Tuple<string, string>("one", "two");

        using (Assert.Multiple())
        {
            await Assert.That(keyValue.Key).IsEqualTo("one");
            await Assert.That(keyValue.Value).IsEqualTo("two");
        }
    }

    public async Task ImplicitOperator3()
    {
        KeyValue keyValue = new KeyValuePair<string, string>("one", "two");

        using (Assert.Multiple())
        {
            await Assert.That(keyValue.Key).IsEqualTo("one");
            await Assert.That(keyValue.Value).IsEqualTo("two");
        }
    }
}