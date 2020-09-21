// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let mutable w1 = "a"
    let mutable w2 = "art"
    // Map<String, Map<String, int>> map = Map.empty
    w1.Split |> Array.iter (fun x -> x)


    0 // return an integer exit code
