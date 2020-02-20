// Learn more about F# at http://fsharp.org

open System

let makingAnagrams (s1:string) (s2:string) =
    let rec matcher str (s:string) =
        match str with
        | x::_ when s.IndexOf(string(x)) <> -1 ->
            let ix = s.IndexOf(string(x))
            ix
        | _ -> matcher str.Tail s
    let b = Seq.toList s1
    let a = matcher b s2
    a


[<EntryPoint>]
let main argv =
    let s1 = "cde"
    let s2 = "abc"
    makingAnagrams s1 s2 |> printf "%A"
    0 // return an integer exit code
