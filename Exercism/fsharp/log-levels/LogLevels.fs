module LogLevels

open System.Text.RegularExpressions

//let parseLine input =
//    Regex.Match(input, "\[(?<level>\w+)\]:\s*(?<message>.*\w)")
//    |> (fun x ->  (x.Groups.["level"].Value.ToLower(), x.Groups.["message"].Value))
// let message (logLine: string): string =
//    logLine |> parseLine |> snd
// let logLevel(logLine: string): string =
//    logLine |> parseLine |> fst
// let reformat(logLine: string): string =
//    let level, message = parseLine logLine
//    $"{message} ({level})"

let message (logLine: string): string =
    (logLine.Split ": " |> Array.last |> Regex.Unescape).Trim()

let logLevel(logLine: string): string = 
    let res = Regex.Match(logLine, "\[(.*?)\]")
    match res.Value with
    | s when s = "[ERROR]" -> "error"
    | s when s = "[INFO]" -> "info"
    | s when s = "[WARNING]" -> "warning"
    | _ -> failwith "No Log line provided"

let reformat(logLine: string): string =
    let level = logLevel logLine
    let msg = message logLine
    $"{msg} ({level})"
