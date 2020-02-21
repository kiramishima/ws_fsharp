namespace LibroDataStructures.Console.Sections

module module5 =
    type Human = {first:string; last:string}
    type IntelligentBeing =
    | Robot of float * int
    | H of Human

    let DiscriminatedUnions = 
        (*
        type Title = String
        type Rating = String
        type Plot = String
        type Ranking = float
        type Year = int
        type Movie = Movie of Title * Rating * Plot * Ranking * Year
        
        let Serenity = Movie("Serenity", "PG-13", "The crew of the ship Serenity tries to evade an assassin sent to recapture one of their number who is telepathic.", 8.0, 2005)
        printfn "%A" Serenity
        *)
        let unit1 = Robot (8.5, 2051)
        printf "%A" unit1
        let unit2 = H {first="Stephen"; last="Hawking"}
        printf "%A" unit2
        0