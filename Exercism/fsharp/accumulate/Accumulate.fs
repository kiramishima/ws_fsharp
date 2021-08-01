module Accumulate

let accumulate (func: 'a -> 'b) (input: 'a list): 'b list =
    let mutable acc = List<'b>.Empty
    let rec demo entries =
        match entries with
        | x::xs ->
            acc <- acc@[(func x)]
            demo xs
        | [] -> acc
    demo input