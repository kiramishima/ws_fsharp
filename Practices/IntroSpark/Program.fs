open System
open Microsoft.Spark.Sql
open Microsoft.Spark.ML


[<EntryPoint>]
let main argv =
    // SparkSession
    let spark = SparkSession
                    .Builder()
                    .AppName("DemoApp")
                    .GetOrCreate()
    
    let dataFrame = spark.Sql("SELECT id, rand() as random_number from range(1000)")

    dataFrame
        .Write()
        .Format("csv")
        .Option("header", true)
        .Option("sep", "|")
        .Mode("overwrite")
        .Save(argv.[1])

    dataFrame.Collect()
        |> Seq.map(fun row -> row.Get(0) :?> int)
        |> Seq.filter(fun id -> id % 2 = 0)
        |> Seq.iter(fun i -> printfn "row %d" i)

    0 // return an integer exit code