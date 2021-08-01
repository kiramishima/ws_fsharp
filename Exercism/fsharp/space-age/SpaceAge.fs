module SpaceAge


let Base = 31557600L
type Planet =
| Earth
| Mercury
| Venus
| Mars
| Jupiter
| Saturn
| Uranus
| Neptune

let age (planet: Planet) (seconds: int64): float =
    match planet with
    | Earth ->
        float (sprintf "%.2f" (float (seconds)/(1.0*float(Base))))
    | Mercury ->
        float (sprintf "%.2f" (float (seconds)/(0.2408467*float(Base))))
    | Venus ->
        float (sprintf "%.2f" (float (seconds)/(0.61519726*float(Base))))
    | Mars ->
        float (sprintf "%.2f" (float (seconds)/(1.8808158*float(Base))))
    | Jupiter ->
        float (sprintf "%.2f" (float (seconds)/(11.862615*float(Base))))
    | Saturn ->
        float (sprintf "%.2f" (float (seconds)/(29.447498*float(Base))))
    | Uranus ->
        float (sprintf "%.2f" (float (seconds)/(84.016846*float(Base))))
    | Neptune ->
        float (sprintf "%.2f" (float (seconds)/(164.79132*float(Base))))