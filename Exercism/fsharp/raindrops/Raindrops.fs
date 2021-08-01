module Raindrops

let convert (number: int): string =
    match number with
    | x when x%105 = 0 -> "PlingPlangPlong"
    | x when x%15 = 0 -> "PlingPlang"
    | x when x%21 = 0 -> "PlingPlong"
    | x when x%35 = 0 -> "PlangPlong"
    | x when x%3 = 0 -> "Pling"
    | x when x%5 = 0 -> "Plang"
    | x when x%7 = 0 -> "Plong"
    | _ -> number.ToString()