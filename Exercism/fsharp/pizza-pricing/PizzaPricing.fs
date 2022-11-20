module PizzaPricing

type Pizza =
| Margherita
| Caprese
| Formaggio
| ExtraSauce of Pizza
| ExtraToppings of Pizza

let rec pizzaPrice (pizza: Pizza): int = 
    match pizza with
    | Margherita -> 7
    | Caprese -> 9
    | Formaggio -> 10
    | ExtraSauce p -> pizzaPrice p + 1
    | ExtraToppings p -> pizzaPrice p + 2

let orderPrice(pizzas: Pizza list): int = 
    let mutable total = [|0; 0|]
    if pizzas.IsEmpty then
        0
    else
        List.toArray pizzas 
        |> Array.iter (fun x ->
            match x with
            | Margherita | Caprese | Formaggio -> 
                total[0] <- total[0] + 1
                total[1] <- total[1] + pizzaPrice x
            | ExtraSauce _ -> 
                total[0] <- total[0] + 1
                total[1] <- total[1] + pizzaPrice x
            | ExtraToppings _ -> 
                total[0] <- total[0] + 1
                total[1] <- total[1] + pizzaPrice x
        )
        total[1] + (if total[0] < 2 then 3 elif total[0] = 2 then 2 else 0)


let orderPrice2(pizzas: Pizza list): int =
    let fee =
        match pizzas.Length with
        | 1 -> 3
        | 2 -> 2
        | _ -> 0
    List.sumBy pizzaPrice pizzas |> (+) fee