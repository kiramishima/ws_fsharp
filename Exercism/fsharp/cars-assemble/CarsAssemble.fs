module CarsAssemble

let successRate (speed: int): float =
    match speed with
    | x when x > 0 && x <= 4 -> 1.0
    | x when x > 4 && x <= 8 -> 0.9
    | x when x = 9 -> 0.8
    | x when x = 10 -> 0.77
    | _ -> 0.0

let productionRatePerHour (speed: int): float =
    float (221 * speed) * (successRate speed)

let workingItemsPerMinute (speed: int): int =
    (221.00 / 60.00) * (float speed) * successRate speed |> int
