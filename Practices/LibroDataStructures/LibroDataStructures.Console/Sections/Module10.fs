namespace LibroDataStructures.Console.Sections

module module10 =
    open FSharp.Data
    type Transaction = JsonProvider<""" {"merchant": "Habbib's", "amount": 90, "time": "2019-02-13T11:00:00.000Z"} """>
    type Account = JsonProvider<""" {"active-card": true, "available-limit": 100} """>
    type Response = JsonProvider<""" {"account": {"active-card": true, "available-limit": 80}, "violations":[]}""">
    type Entry =
    | A of Account
    | T of Transaction

    let OperationX data =
        printf "%s" (data.GetType().FullName)
        // printf "%A" account
        (*match data with
        | A { = a; "available-limit" = b} -> printf "Account"
        | _ -> "Nothing"*)