// Learn more about F# at http://fsharp.org
namespace LibroDataStructures.Console

open System
open Sections.module5

module Application =
    [<EntryPoint>]
    let main argv =
        
        printfn "Hello World from F#!"

        // Discriminated unions
        DiscriminatedUnions |> ignore
        0 // return an integer exit code
