namespace ModularPipelines.UnitTests.FSharp

open System
open System.Collections
open System.Reflection
open System.Threading.Tasks

[<RequireQualifiedAccess>]
module CSharpTestWrapper =
    let private bindingFlags =
        BindingFlags.Instance ||| BindingFlags.Public ||| BindingFlags.NonPublic ||| BindingFlags.DeclaredOnly

    let private getArgumentsFromAttribute (attribute: obj) =
        let attributeType = attribute.GetType()
        let property =
            attributeType.GetProperty("Arguments")
            ?? attributeType.GetProperty("Data")

        if isNull property then
            invalidOp ($"Could not find an arguments property on {attributeType.FullName}")

        match property.GetValue(attribute) with
        | :? obj[] as arguments -> arguments
        | :? IEnumerable as arguments -> arguments |> Seq.cast<obj> |> Array.ofSeq
        | null -> [||]
        | argument -> [| argument |]

    let private getArguments (methodInfo: MethodInfo) (argumentIndex: int) =
        methodInfo.GetCustomAttributes(true)
        |> Array.filter (fun attribute -> attribute.GetType().Name.StartsWith("ArgumentsAttribute", StringComparison.Ordinal))
        |> Array.item argumentIndex
        |> getArgumentsFromAttribute

    let invokeTest (instance: obj) (testType: Type) (methodName: string) (argumentIndex: int option) = async {
        let methodInfo =
            testType.GetMethods(bindingFlags)
            |> Array.find (fun methodInfo -> methodInfo.Name = methodName)

        let arguments =
            match argumentIndex with
            | Some index -> getArguments methodInfo index
            | None -> [||]

        match methodInfo.Invoke(instance, arguments) with
        | null -> ()
        | :? Task as task ->
            do! task |> Async.AwaitTask
        | result ->
            invalidOp ($"Expected Task result from {testType.FullName}.{methodName}, but received {result.GetType().FullName}")
    }
