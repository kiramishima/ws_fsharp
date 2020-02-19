// Learn more about F# at http://fsharp.org

open System

let makingAnagrams (s1:string) (s2:string) =
    let mutable idx = 0
    let mutable idx2 = 0
    let mutable acc = 0
    for i in 0..s1.Length-1 do
        let str = s1.[i]
        idx2 <- s2.IndexOf(str)
        if idx2 <> -1 then
            idx <- idx2
        else
            acc <- acc+i
    for i in 0..idx do
        acc <- acc+i
    acc

[<EntryPoint>]
let main argv =
    let s1 = "cde"
    let s2 = "abc"
    makingAnagrams s1 s2 |> printf "%A"
    0 // return an integer exit code
