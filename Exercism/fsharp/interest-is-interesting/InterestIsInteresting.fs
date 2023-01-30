module InterestIsInteresting

let interestRate (balance: decimal): single =
   match balance with
   | x when x < 0m -> 3.213f
   | x when x >= 0m && x < 1_000m -> 0.5f
   | x when x >= 1_000m && x < 5_000m -> 1.621f
   | _ -> 2.475f


let interest (balance: decimal): decimal =
   balance * (balance |> interestRate |> decimal ) / 100m

let annualBalanceUpdate(balance: decimal): decimal =
   balance + (balance |> interest)

let amountToDonate(balance: decimal) (taxFreePercentage: float): int =
   match balance with
   | x when x > 0m -> (x * (decimal (taxFreePercentage * 0.01 * 2.0))) |> int
   | _ -> 0