// Learn more about F# at http://fsharp.org

open System

let twoStrings(s1:string, s2:string): string=
    "YES"

[<EntryPoint>]
let main argv =
    let mutable w1 = "a"
    let mutable w2 = "art"
    // Map<String, Map<String, int>> map = Map.empty
    let x = w1.Split "" |> Array.toList
    let y = w2.Split "" |> Array.toList
    Console.WriteLine x
    // let mutable contains = 0
    let mutable dictionary: Map<string, int> = Map.empty
    for i in x do
        Console.WriteLine i
        dictionary.Add(i, 0)
 
    Console.WriteLine dictionary

    dictionary |> Map.iter (fun key value -> 
        Console.WriteLine key.ToString
    )
        

    0 // return an integer exit code
