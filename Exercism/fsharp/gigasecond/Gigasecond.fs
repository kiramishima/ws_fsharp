module Gigasecond
open System

let add (beginDate: DateTime) =
    Math.Pow(10, 9) |> beginDate.AddSeconds