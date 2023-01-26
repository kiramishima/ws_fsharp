module CollatzConjecture

let steps (number: int): int option =
    let rec steps2 (n: int option) (x: int) =
        match n with
        | n when n.Value > 1 ->
            match n.Value%2 with 
            | 0 -> steps2 (Some(n.Value/2)) (x + 1)
            | 1 -> steps2 (Some(n.Value*3+1)) (x+1)
            | _ -> None
        | n when n.Value = 1 -> Some x
        | _ -> None

    steps2 (Some(number)) 0
