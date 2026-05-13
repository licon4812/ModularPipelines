namespace ModularPipelines.UnitTests.FSharp

open System
open System.Diagnostics
open System.Reflection
open System.Runtime.ExceptionServices
open System.Threading.Tasks

[<RequireQualifiedAccess>]
module CSharpTestWrapper =
    let private bindingFlags =
        BindingFlags.Instance ||| BindingFlags.Public ||| BindingFlags.NonPublic ||| BindingFlags.DeclaredOnly

    let rec private getArgumentValue (argument: CustomAttributeTypedArgument) =
        if argument.ArgumentType.IsArray then
            match argument.Value with
            | :? System.Collections.IEnumerable as values ->
                values
                |> Seq.cast<CustomAttributeTypedArgument>
                |> Seq.map getArgumentValue
                |> Array.ofSeq
                :> obj
            | null -> [||] :> obj
            | value -> value
        else
            argument.Value

    let private getArguments (methodInfo: MethodInfo) (argumentIndex: int) =
        methodInfo.CustomAttributes
        |> Seq.filter (fun attribute -> attribute.AttributeType.Name.StartsWith("ArgumentsAttribute", StringComparison.Ordinal))
        |> Seq.toArray
        |> Array.item argumentIndex
        |> fun attribute ->
            match attribute.ConstructorArguments |> Seq.toArray with
            | [| singleArgument |] when singleArgument.ArgumentType.IsArray ->
                getArgumentValue singleArgument :?> obj array
            | arguments ->
                arguments |> Array.map getArgumentValue

    let private rethrow (error: exn) =
        let innerException =
            match error with
            | :? TargetInvocationException as targetInvocationException when not (isNull targetInvocationException.InnerException) ->
                Some targetInvocationException.InnerException
            | :? AggregateException as aggregateException when aggregateException.InnerExceptions.Count = 1 ->
                Some aggregateException.InnerExceptions[0]
            | _ -> None

        match innerException with
        | Some innerException ->
            ExceptionDispatchInfo.Capture(innerException).Throw()
            raise innerException
        | None -> raise error

    let invokeTest (instance: obj) (testType: Type) (methodName: string) (methodIndex: int) (argumentIndex: int option) = async {
        let methodInfo =
            testType.GetMethods(bindingFlags)
            |> Array.filter (fun candidate -> candidate.Name = methodName)
            |> Array.sortBy (fun candidate -> candidate.MetadataToken)
            |> Array.item methodIndex

        let arguments =
            match argumentIndex with
            | Some index -> getArguments methodInfo index
            | None -> [||]

        try
            match methodInfo.Invoke(instance, arguments) with
            | :? Task as task -> do! task |> Async.AwaitTask
            | null -> ()
            | result -> invalidOp $"Expected Task result from {testType.FullName}.{methodName}, but received {result.GetType().FullName}"
        with error ->
            return rethrow error
    }
