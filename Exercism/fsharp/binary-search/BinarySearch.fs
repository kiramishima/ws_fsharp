module BinarySearch

let find input value =
    let rec findrec input index =
        match input with
        | [] -> None
        | head::last ->
            if head = value then
                Some index
            else
                findrec last (index+1)
    findrec (input |> Array.toList) 0