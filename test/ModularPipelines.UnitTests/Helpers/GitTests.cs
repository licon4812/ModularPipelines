using ModularPipelines.Context;
using ModularPipelines.Git;
using ModularPipelines.Git.Extensions;
using ModularPipelines.Git.Options;
using ModularPipelines.Models;
using ModularPipelines.Modules;
using ModularPipelines.TestHelpers;
using ModularPipelines.TestHelpers.Assertions;

namespace ModularPipelines.UnitTests.Helpers;

public class GitTests : TestBase
{
    private class GitVersionModule : Module<CommandResult>
    {
        protected internal override async Task<CommandResult?> ExecuteAsync(IModuleContext context, CancellationToken cancellationToken)
        {
            return await context.Git().Commands.Git(new GitBaseOptions
            {
                Version = true,
            }, token: cancellationToken);
        }
    }

    public async Task Has_Not_Errored()
    {
        var moduleResult = await await RunModule<GitVersionModule>();

        await ModuleResultAssertions.AssertSuccessWithValue(moduleResult);
    }

    public async Task Standard_Output_Starts_With_Git_Version()
    {
        var moduleResult = await await RunModule<GitVersionModule>();

        using (Assert.Multiple())
        {
            await Assert.That(moduleResult.ValueOrDefault!.StandardError).IsNull().Or.IsEmpty();
            await Assert.That(moduleResult.ValueOrDefault.StandardOutput).Matches(@"git version \d+.*");
        }
    }

    public async Task GitRootDirectory()
    {
        var git = await GetService<IGit>();

        using (Assert.Multiple())
        {
            await Assert.That(git.RootDirectory.Name).IsEqualTo("ModularPipelines");
            await Assert.That(git.RootDirectory.ListFiles().Select(x => x.Name)).Contains("README.md");
        }
    }

    public async Task DefaultBranchName()
    {
        var git = await GetService<IGit>();
        await Assert.That(git.Information.DefaultBranchName).IsEqualTo("main");
    }
}
