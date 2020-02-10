namespace HackerLab

open System

module TestLabs =
    let rec limpiarParejas (s:string) =
        let a = s.Contains "()" 
        if a then
            let c = s.Replace("()", "")
            limpiarParejas c
        else
            s
        
    let getMin (s:string): int =
        let str = limpiarParejas s
        if (String.length str) = 0 then
            0
        elif string(str.[0]) = "(" then
            String.length str
        else
            let t0 = str |> Seq.toArray |> Array.map (fun x -> string(x))
            // printf "%A" t0
            let (t1, t2) = Array.partition (fun x -> x = "(") t0
            // printf "%A" t1
            t1.Length + t2.Length


    // Ex 2
    let minX (arr: int[]): int =
        let mutable acc = 0
        let t = seq { for i in 0 .. (arr.Length-1) do yield acc <- acc + arr.[i]}
        let np = Seq.min t
        (Math.Abs np) + 1

    // Ex 3
    let countNonUnique (numbers: int[]): int =
        numbers |> Seq.groupBy (fun x -> x) |> Seq.map (fun (a, b) -> b) |> Seq.filter (fun x -> (Seq.length x) > 1) |> Seq.length
    // Ex 4
    let minDiff (arr: int[]): int =
        // let x = true
        let t = Array.sort arr
        let y = seq { for i in 0..(arr.Length - 2) do yield (t.[i], t.[i+1])}
        y |> Seq.map (fun (a, b) -> (Math.Abs a - b)) |> Seq.reduce (fun a b -> a+b) |> int

    [<EntryPoint>]
    let main argv =
        // let str = "()()"
        // let r = getMin str
        // printf "%A" r
        // Ex 1
        let str1 = ")("
        let r1 = getMin str1
        printf "%A" r1
        // Ex 2
        // Ex 3
        let n = [|1;2;3|]
        let r3 = countNonUnique n
        printf "%A" n
        0 // return an integer exit code

