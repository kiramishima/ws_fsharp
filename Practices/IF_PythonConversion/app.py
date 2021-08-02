from __future__ import print_function
from pyspark.sql import SparkSession
from pyspark.sql import Row
from pyspark.sql.types import *

def basic_df_example(spark):
    df = spark.read.json("./DATASETS/people.json")
    df.show()
    # Print Schema
    df.printSchema()
    # Select Column
    df.select("name").show()
    # Selecting two columns and performing a calculation on the age column
    df.select(df['name'], df['age'] + 1).show()
    # Filtering a DataFrame using the Gt function on the Column objec
    df.filter(df['age'] > 21).show()
    # Aggregations in Apache Spark
    df.groupBy("age").count().show()
    # Making a DataFrame accessible by the SQL context
    df.createOrReplaceTempView("people")
    sqlDF = spark.sql("SELECT * FROM people")
    sqlDF.show()
    # Making a DataFrame accessible to other SparkSession’s SQL context
    df.createGlobalTempView("people")
    spark.sql("SELECT * FROM global_temp.people").show()
    spark.newSession().sql("SELECT * FROM global_temp.people").show()


if __name__ == "__main__":
    # $example on:init_session$
    spark = SparkSession \
        .builder \
        .appName("Python Spark SQL basic example") \
        .config("spark.some.config.option", "some-value") \
        .getOrCreate()
    # $example off:init_session$

    basic_df_example(spark)

    spark.stop()