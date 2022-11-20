module TisburyTreasureHunt

open System

let getCoordinate (line: string * string): string =
    let (_, coord) = line
    coord

let convertCoordinate (coordinate: string): int * char = 
    let arr = coordinate.ToCharArray()
    ((Char.GetNumericValue arr[0] |> int), arr[1])

let compareRecords (azarasData: string * string) (ruisData: string * (int * char) * string) : bool = 
    let (_, coordinate) = azarasData
    let (_, (x, c), _) = ruisData
    match (coordinate, $"{x}{c}") with
    | (x, y) when x = y -> true
    | _ -> false

let createRecord (azarasData: string * string) (ruisData: string * (int * char) * string) : (string * string * string * string) =
    match ((compareRecords azarasData ruisData), azarasData, ruisData) with
    | (true, (ab, ac), (ad, _, ag)) -> (ac, ad, ag, ab)
    | _ -> ("", "", "", "")
