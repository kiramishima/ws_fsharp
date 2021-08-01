module Clock

open System

let create hours minutes =
    let mutable hrs = 0
    if hours < 0 then
        hrs <- 24 + hours
    else
        hrs <- hours
    TimeSpan(hrs, minutes, 0)

let add (minutes:int) (clock: TimeSpan) =
    let m = TimeSpan.FromMinutes(double(minutes))
    clock.Add(m)

let subtract (minutes:int) (clock: TimeSpan) =
    let m = TimeSpan.FromMinutes(double(minutes))
    clock.Subtract(m)

let display (clock: System.TimeSpan) =
    String.Format("{0:hh\\:mm}", clock)