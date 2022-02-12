namespace BigOChapter.Application.Excercises

module Ex2 =
    // Ex 2
    let PairSum (a:int) (b:int) =
        a + b
        
    let PairSumSequence (n:int) =
        let mutable sum = 0
        for i in 0..n do
            sum <- sum + (PairSum i (i + 1))
            
        sum
    
    