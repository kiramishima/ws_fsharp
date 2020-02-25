// Learn more about F# at http://fsharp.org
namespace LibroDataStructures.Console

open System
open FSharp.Data
open Sections.module5
open Sections.module10

module Application =
    [<EntryPoint>]
    let main argv =
        
        printfn "Hello World from F#!"
        let x = JsonValue.Parse("""
            {"transaction": {"merchant": "Burger King", "amount": 20, "time":"2019-02-13T10:00:00.000Z"}
        """)
        let y = JsonValue.Parse("""
            {"transaction": {"merchant": "Burger King", "amount": 20, "time":"2019-02-13T10:00:00.000Z"}
        """)
        OperationX x |> ignore
        // Discriminated unions
        DiscriminatedUnions |> ignore
        0 // return an integer exit code
