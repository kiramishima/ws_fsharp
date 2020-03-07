// Learn more about F# at http://fsharp.org

open System

let parse (s: string) =
    match (System.Int32.TryParse(s)) with
    | (true, value) ->  Ok value
    | (false, _) -> Error "Invalid int"

let sockMerchant (n:int) (ar: int[]) =
    let r = ar |> Array.groupBy (fun x -> x) |> Array.map (fun (x, y) -> y)
    let mutable x = 0
    for i in 0..r.Length-1 do
        x <- ((r.[i].Length - (r.[i].Length%2) ) / 2) + x
    x

[<EntryPoint>]
let main argv =
    // let(n, m) = Console.ReadLine() |> parse
    let n = int <| Console.ReadLine()
    let ar = Console.ReadLine().Split(' ') |> Array.map (fun x -> x |> Convert.ToInt32)
    sockMerchant n ar |> Console.WriteLine
    0 // return an integer exit code
