module Seq

let keep pred xs = 
    match xs with
        | x when x |> Seq.isEmpty -> []
        | _ ->
            let xr = xs |> Seq.toArray |> Array.partition pred
            match xr with
            | a, _ -> a |> Array.toList

let discard pred xs = 
    match xs with
        | x when x |> Seq.isEmpty -> []
        | _ ->
            let xr = xs |> Seq.toArray |> Array.partition pred
            match xr with
            | _, b -> b |> Array.toList