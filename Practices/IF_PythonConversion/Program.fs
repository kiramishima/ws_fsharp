open System
open Microsoft.Spark.Sql
// open Microsoft.Spark.Sql.Types

let BasicDfExample (spark: SparkSession) =
    let dataFrame = spark.Read().Json("./DATASETS/people.json")
    dataFrame.Show()
    // printing schema
    dataFrame.PrintSchema()
    // Select single column
    dataFrame.Select("name").Show()
    // Selecting multiple columns and performing a calculation in F#
    // including the more explicit “.Plus” call
    dataFrame.Select(dataFrame.["name"], (dataFrame.["age"] + 1)).Show()
    dataFrame.Select(dataFrame.["name"], (dataFrame.["age"].Plus(1))).Show()
    // Filtering a DataFrame using the Gt function on the Column objec
    dataFrame.Filter(dataFrame.["age"].Gt(21)).Show()
    // Aggregations in Apache Spark
    dataFrame.GroupBy(dataFrame.["age"]).Count().Show()
    // Making a DataFrame accessible by the SQL
    dataFrame.CreateOrReplaceTempView("people")
    let sqlDataFrame = spark.Sql("SELECT * FROM people")
    // Making a DataFrame accessible to other SparkSession’s SQL context
    dataFrame.CreateGlobalTempView("people")
    spark.Sql("SELECT * FROM global_temp.people").Show()
    spark.NewSession().Sql("SELECT * FROM global_temp.people").Show()


[<EntryPoint>]
let main argv =
    let spark = SparkSession.Builder().GetOrCreate()
    BasicDfExample spark
    0 // return an integer exit code