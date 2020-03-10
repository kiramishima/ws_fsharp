namespace LibroDataStructures.Console.Sections
open Microsoft.FSharp.Core

module module10 =
    open System
    open Newtonsoft.Json

    [<AllowNullLiteral>]
    type Transaction()= class
        let mutable merchant = ""
        let mutable amount = 0
        let mutable time:DateTime = DateTime.Now
        let mutable _time:string = ""
        [<JsonProperty("merchant")>]
        member self.Active
            with get() = merchant
            and set(value) = merchant <- value
        [<JsonProperty("available")>]
        member self.Amount
            with get() = amount
            and set(value) = amount <- value
        [<JsonProperty("time")>]
        member self.Time
            with get() = _time
            and set(value) =
                let formatter = DateTime.Parse value
                time <- formatter
    end
    
    // JsonProvider<""" {"merchant": "Habbib's", "c": 90, "time": "2019-02-13T11:00:00.000Z"} """>
    type Account()= class
        let mutable active = false
        let mutable available = 0
        [<JsonProperty("active-card")>]
        member self.Active
            with get() = active
            and set(value) = active <- value
        [<JsonProperty("available-limit")>]
        member self.Available
            with get() = available
            and set(value) = available <- value

    end
    // JsonProvider<""" {"active-card": true, "available-limit": 100} """>
    [<AllowNullLiteral>]
    type ParserJSON()=
        class
            let mutable account = Account
            let mutable transaction = Transaction
            [<JsonProperty("account")>]
            member self.Account
                with get() = account
                and set(value) = account <- value
            [<JsonProperty("transaction")>]
            member self.Transaction
                with get() = transaction
                and set(value) = transaction <- value
        end

    type Entry =
    | A of Account
    | T of Transaction

    let OperationX (data:ParserJSON) =
        printf "%s" (data.GetType().FullName)
        printf "%A" data
        printf "%A" (data.Transaction.GetType().FullName)
        (*match data with
        | x when isNull x.Account. -> "Account"
        | x when x.Transaction <> null -> "Transaction"*)
