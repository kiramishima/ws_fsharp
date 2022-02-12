namespace BigOChapter.Application.Excercises

module Ex1 =
    // Ex 1
    let rec Sum (n: int) =
        if n <= 0 then 0
        else n + Sum(n-1)
    