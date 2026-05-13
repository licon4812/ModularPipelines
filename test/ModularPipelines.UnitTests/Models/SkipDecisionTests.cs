using ModularPipelines.Models;

namespace ModularPipelines.UnitTests.Models;

public class SkipDecisionTests
{
    public async Task True_Implicit_Cast()
    {
        SkipDecision skipDecision = true;

        using (Assert.Multiple())
        {
            await Assert.That(skipDecision.ShouldSkip).IsTrue();
            await Assert.That(skipDecision.Reason).IsNull();
        }
    }

    public async Task String_Implicit_Cast()
    {
        SkipDecision skipDecision = "Foo!";

        using (Assert.Multiple())
        {
            await Assert.That(skipDecision.ShouldSkip).IsTrue();
            await Assert.That(skipDecision.Reason).IsEqualTo("Foo!");
        }
    }

    public async Task False_Implicit_Cast()
    {
        SkipDecision skipDecision = false;

        using (Assert.Multiple())
        {
            await Assert.That(skipDecision.ShouldSkip).IsFalse();
            await Assert.That(skipDecision.Reason).IsNull();
        }
    }

    public async Task Skip()
    {
        var skipDecision = SkipDecision.Skip("Blah!");

        using (Assert.Multiple())
        {
            await Assert.That(skipDecision.ShouldSkip).IsTrue();
            await Assert.That(skipDecision.Reason).IsEqualTo("Blah!");
        }
    }

    public async Task DoNotSkip()
    {
        var skipDecision = SkipDecision.DoNotSkip;

        using (Assert.Multiple())
        {
            await Assert.That(skipDecision.ShouldSkip).IsFalse();
            await Assert.That(skipDecision.Reason).IsNull();
        }
    }

    [Arguments(true)]
    [Arguments(false)]
    public async Task Of(bool shouldSkip)
    {
        var skipDecision = SkipDecision.Of(shouldSkip, "Blah!");

        using (Assert.Multiple())
        {
            await Assert.That(skipDecision.ShouldSkip).IsEqualTo(shouldSkip);
            await Assert.That(skipDecision.Reason).IsEqualTo(shouldSkip ? "Blah!" : null);
        }
    }
}