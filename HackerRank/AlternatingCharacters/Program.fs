// Learn more about F# at http://fsharp.org

open System

let alternatingCharacters (s:string): int =
    let sstr = Seq.toList s
    let total = sstr |> Seq.groupBy (fun x -> "AB")
    sstr.Length

[<EntryPoint>]
let main argv =
    let input = "ABAB"
    alternatingCharacters input |> Console.WriteLine
    0 // return an integer exit code
