// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

namespace BigOChapter.Application

open System
open Excercises.Ex1
open Excercises.Ex2

module Application =
    [<EntryPoint>]
    let main argv =
        // Ex 1
        let x = Sum 4
        printfn $"x = {x}"
        // Ex 2
        let x2 = PairSumSequence 4
        printfn $"x2 = {x2}"
        0 // return an integer exit code