open System
open Microsoft.Spark.Sql
open Microsoft.Spark.ML

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let spark = SparkSession.Builder().Master("local[*]").AppName("test").GetOrCreate()
    let flights = spark.Read().Option("delimiter", ",").Option("inferSchema", "true").Option("header", "True").Option("nullValue", "NA").Csv("flights.csv")
    printf "Total Records: %A\n" (flights.Count())
    flights.Show 5

    // Printing DTypes
    for f in flights.Schema().Fields do
        printf "%A\n" f.DataType

    let flights_drop_column = flights.Drop("flight")
    // Number of records with missing 'delay' values
    printf "Total: %A\n" (flights_drop_column.Filter("delay IS NULL").Count())
    // Remove records with missing 'delay' values
    let flights_valid_delay = flights_drop_column.Filter("delay IS NOT NULL")

    let flights_none_missing = flights_valid_delay.Drop()
    printf "Total: %A\n" (flights_none_missing.Count())

    // Convert 'mile' to 'km' and drop 'mile' column
    let mutable flights_km = flights.WithColumn("km", Functions.Round(flights.Col("mile") * 1.60934, 0)).Drop("mile")

    // Create 'label' column indicating whether flight delayed (1) or not (0)
    flights_km <- flights_km.WithColumn("label", flights_km.Col("delay").Geq("15").Cast("integer"))

    // 
    flights_km.Show(5)


    // Categorical columns
    let indexer = Feature.Bucketizer()

    spark.Stop()
    0