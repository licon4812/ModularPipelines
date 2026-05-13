namespace ModularPipelines.UnitTests.FSharp.Models

open System.Collections.Generic
open ModularPipelines.Models
open TUnit.Assertions
open TUnit.Assertions.Extensions
open TUnit.Assertions.FSharp.Operations
open TUnit.Core

type CommandLineTests() =
    [<Test>]
    member _.CommandLine_StoresToolAndArguments() = async {
        let commandLine = CommandLine("git", ["add"; "--all"])
        do! check(StringEqualsAssertionExtensions.IsEqualTo(Assert.That(commandLine.Tool), "git"))
        do! check(Assert.That(commandLine.Arguments).IsEquivalentTo([| "add"; "--all" |]))
    }

    [<Test>]
    member _.CommandLine_ToString_FormatsCorrectly() = async {
        let commandLine = CommandLine("git", ["commit"; "-m"; "test message"])
        do! check(StringEqualsAssertionExtensions.IsEqualTo(Assert.That(commandLine.ToString()), "git commit -m test message"))
    }

    [<Test>]
    member _.CommandLine_EmptyArguments_ToStringShowsToolOnly() = async {
        let commandLine = CommandLine("git", [])
        do! check(StringEqualsAssertionExtensions.IsEqualTo(Assert.That(commandLine.ToString()), "git"))
    }

    [<Test>]
    member _.CommandLine_ArgumentsAreImmutable() = async {
        let args = List<string>(["add"])
        let commandLine = CommandLine("git", args)
        args.Add("--all")
        do! check(Assert.That(commandLine.Arguments).HasCount().EqualTo(1))
    }
