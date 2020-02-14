// Learn more about F# at http://fsharp.org

open System

let rec superReducedString (s:string): string =
    let str = Seq.toList s
    if str.Length = 0 then
        s
    elif str.Length > 0 then
        match str.Head then
        |> x = str.Tail.Head -> String.concat("", str.Tail.Tail)
        |> _ -> ""
        ""

[<EntryPoint>]
let main argv =
    // let s = Console.ReadLine()
    let s = "aaabccddd"
    superReducedString s
    |> Console.WriteLine
    0 // return an integer exit code
