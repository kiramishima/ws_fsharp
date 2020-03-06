// Learn more about F# at http://fsharp.org

open System

let sockMerchant (n:int) (ar: int[]) =

    0

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let n = 9
    let ar = [|10; 20; 20; 10; 10; 30; 50; 10; 20|]
    sockMerchant n ar |> Console.WriteLine
    0 // return an integer exit code
