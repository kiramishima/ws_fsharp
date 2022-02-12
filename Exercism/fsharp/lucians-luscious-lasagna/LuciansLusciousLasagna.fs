module LuciansLusciousLasagna

let expectedMinutesInOven =
    40

let remainingMinutesInOven (minutes:int) =
    expectedMinutesInOven - minutes

let preparationTimeInMinutes (layers:int) =
    layers*2

let elapsedTimeInMinutes (layers:int) (minutes:int) =
    let calc = (preparationTimeInMinutes layers) + minutes
    calc