// Learn more about F# at http://fsharp.org

open System

let sockMerchant (n:int) (ar: int[]) =
    let r = ar |> Array.groupBy id |> Array.map (fun (x, y) -> y)
    let mutable x = 0
    for i in 0..r.Length-1 do
        x <- ((r.[i].Length - (r.[i].Length%2) ) / 2) + x
    x

[<EntryPoint>]
let main argv =
    let n = int <| Console.ReadLine()
    let ar = Console.ReadLine().Split(' ') |> Array.map (fun x -> x |> Convert.ToInt32)
    sockMerchant n ar |> Console.WriteLine
    0 // return an integer exit code
