﻿module QueenAttack

let create (position: int * int) = 
    match position with
    | (x, y) when (x>= 0 && x<= 7) && (y>= 0 && y<= 7) -> true
    | _ -> false

let canAttack (queen1: int * int) (queen2: int * int) =
    let (x1, y1) = queen1
    let (x2, y2) = queen2
    if x1 = x2 then
        true
    elif y1 = y2 then
        true
    elif abs(x1 - x2) = abs(y1-y2) then
        true
    else
        false
