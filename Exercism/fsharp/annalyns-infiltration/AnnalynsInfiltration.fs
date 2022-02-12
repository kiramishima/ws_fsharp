module AnnalynsInfiltration

let canFastAttack (knightIsAwake: bool): bool = not knightIsAwake // then true else false

let canSpy (knightIsAwake: bool) (archerIsAwake: bool) (prisonerIsAwake: bool): bool = knightIsAwake || archerIsAwake || prisonerIsAwake // then true else false

let canSignalPrisoner (archerIsAwake: bool) (prisonerIsAwake: bool): bool = not archerIsAwake && prisonerIsAwake // then true else false

let canFreePrisoner (knightIsAwake: bool) (archerIsAwake: bool) (prisonerIsAwake: bool) (petDogIsPresent: bool): bool =
    if petDogIsPresent then
        if not archerIsAwake && knightIsAwake && prisonerIsAwake then
            true
        elif not archerIsAwake && knightIsAwake && not prisonerIsAwake then
            true
        elif not archerIsAwake && not knightIsAwake && not prisonerIsAwake then
            true
        elif not archerIsAwake && not knightIsAwake && prisonerIsAwake then
            true
        elif archerIsAwake && not knightIsAwake && not prisonerIsAwake then
            false
        else
            false
    else
        if not knightIsAwake && not archerIsAwake && prisonerIsAwake then
            true
        else
            false

let canFreePrisoner2 (knightIsAwake: bool) (archerIsAwake: bool) (prisonerIsAwake: bool) (petDogIsPresent: bool): bool =
    match (knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent) with
    | false, false, true, _ -> true
    | false, false, _, true -> true
    | true, false, _, true -> true
    | _ -> false