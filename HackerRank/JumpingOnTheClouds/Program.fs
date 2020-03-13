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
    let n = c.Length
    let mutable sum : int list = []
    //let mutable sum2 = 0
    (*let rec operation (index: int) (head: int) (tail: int List) =
        if index =< n then
            if head=0 && head=tail.Head then
                sum <- index + 1 :: sum
                operation (index + 1) tail.Head tail.Tail
            elif head=0 && head=tail.Tail.Head then
                sum <- index + 2 :: sum
                operation (index + 2) tail.Head tail.Tail
        elif index > n then
            List.*)
    let rec jumps (index: int) (x: int[]) =
        let cx = x |> Array.toList
        match cx with
        | [] -> 0
        | [a] -> 
            printf "+++++++++\n %A | %A \n++++++++++" a []
            jumps (index + 2) ([] |> Seq.toArray)
        | a::ax -> 
            printf "+++++++++\n %A | %A \n++++++++++" a ax
            jumps (index + 2) (ax.Tail |> Seq.toArray)
        
        | a::ax when a = ax.Head && a = ax.Tail.Head ->
            sum <- (index + 2) :: sum
            jumps (index + 2) (ax.Tail |> Seq.toArray)
        | a::ax when a = ax.Head ->
            sum <- (index + 1) :: sum
            jumps (index + 1) (ax.Tail |> Seq.toArray)

    let res = jumps 0 c
    Console.WriteLine res

    printf "%A" sum
    0 // return an integer exit code
