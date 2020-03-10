// Learn more about F# at http://fsharp.org

open System

let jumpingOnClouds (c: int[]): int =
    0

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let c = [|0; 1; 0; 0; 0; 1; 0|]
    // 1 - Vale versia
    // 0 - Zona segura
    // Saltos = 1 o 2
    // 0 - 2 - 4 - 6
    // 0 - 2 - 3 - 4 - 6
    let mutable sum : int list = []
    //let mutable sum2 = 0
    for i in 0..c.Length-2 do
        printfn "%i - %i" c.[i] c.[i+1]
        if c.[i] = 0 && c.[i+1] = 0 then
            sum <- i::sum
        elif c.[i] = 1 && c.[i+1] = 0 then
            sum <- i+1::sum
    printf "%A" sum
    0 // return an integer exit code
