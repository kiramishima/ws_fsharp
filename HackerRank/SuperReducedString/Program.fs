// Learn more about F# at http://fsharp.org

open System
// open System.Text.RegularExpressions

let rec superReducedString (s:String) =
    let str = List.ofSeq s
    (*let a = str.GetType()
    printf "%A\n" a.FullName
    printf "%A\n" str
    printf "%A\n" str.Head
    printf "%A\n" str.Tail
    printf "%A\n" str.Tail.Head*)
    match str with
    | [] -> printf "Empty String"
    | x::xs -> 
        printfn "%A\n" x
        printfn "%A\n" xs
        if x = xs.Head then
            superReducedString (xs.Tail |> Seq.map (fun a -> string(a)) |> String.concat "")
        else
            superReducedString (string(x)+(xs |> Seq.map (fun a -> string(a)) |> String.concat ""))
    | x -> printf "%s" (x |> Seq.map (fun a -> string(a)) |> String.concat "")
    (*if str.Length = 0 then
        s
    elif str.Length > 0 then
        let s2 = match str with
        | x::xs -> 
            printf "%A" x
            printf "%A" xs
            // let s2 = String.concat "" str
            // superReducedString s2
            s
        | [] -> s
        s2*)


(*let rec superReducedString (s:string): string =
    let rx = Regex(@"\b(?<word>\w+)(?=<word>)\b", RegexOptions.Compiled)
    let matches = rx.Matches(s)
    if matches.Count = 0 then
        s
    else
        superReducedString(rx.Replace(s, ""))*)

[<EntryPoint>]
let main argv =
    // let s = Console.ReadLine()
    let s = "aaabccddd"
    superReducedString s
    |> Console.WriteLine
    0 // return an integer exit code
