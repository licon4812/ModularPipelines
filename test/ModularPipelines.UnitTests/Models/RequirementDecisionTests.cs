using ModularPipelines.Models;

namespace ModularPipelines.UnitTests.Models;

public class RequirementDecisionTests
{
    public async Task True_Implicit_Cast()
    {
        RequirementDecision requirementDecision = true;

        using (Assert.Multiple())
        {
            await Assert.That(requirementDecision.Success).IsTrue();
            await Assert.That(requirementDecision.Reason).IsNull();
        }
    }

    public async Task False_Implicit_Cast()
    {
        RequirementDecision requirementDecision = false;

        using (Assert.Multiple())
        {
            await Assert.That(requirementDecision.Success).IsFalse();
            await Assert.That(requirementDecision.Reason).IsNull();
        }
    }

    public async Task String_Implicit_Cast()
    {
        RequirementDecision requirementDecision = "Foo!";

        using (Assert.Multiple())
        {
            await Assert.That(requirementDecision.Success).IsFalse();
            await Assert.That(requirementDecision.Reason).IsEqualTo("Foo!");
        }
    }

    public async Task Failed()
    {
        var requirementDecision = RequirementDecision.Failed("Blah!");

        using (Assert.Multiple())
        {
            await Assert.That(requirementDecision.Success).IsFalse();
            await Assert.That(requirementDecision.Reason).IsEqualTo("Blah!");
        }
    }

    public async Task Passed()
    {
        var requirementDecision = RequirementDecision.Passed;

        using (Assert.Multiple())
        {
            await Assert.That(requirementDecision.Success).IsTrue();
            await Assert.That(requirementDecision.Reason).IsNull();
        }
    }

    [Arguments(true)]
    [Arguments(false)]
    public async Task Of(bool success)
    {
        var requirementDecision = RequirementDecision.Of(success, "Blah!");

        using (Assert.Multiple())
        {
            await Assert.That(requirementDecision.Success).IsEqualTo(success);
            await Assert.That(requirementDecision.Reason).IsEqualTo(!success ? "Blah!" : null);
        }
    }
}