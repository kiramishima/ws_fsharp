// Learn more about F# at http://fsharp.org

open System
open Deedle
// open XPlot.Plotly
open XPlot.GoogleCharts

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let globalTemp  = Frame.ReadCsv("datasets/global_temperature.csv")
    globalTemp.Print()
    globalTemp.GetRowsAt(0,1,2,3).Print()
    globalTemp.Rows.Between(0, 3).Print()


    // Obteniendo la Serie
    let year = globalTemp.GetColumn<int16>("year")
    let degreesCelsius = globalTemp.GetColumn<double>("degrees_celsius")
    
    // Ploty
    (*let lineTrace1 =
        Scatter(
            x = year.Values,
            y = degreesCelsius.Values,
            name = ""
        )

    let styledLayout =
        Layout(
            title = "Temperatura de 1850 a 2016",
            xaxis =
                Xaxis(
                    title = "Years",
                    showgrid = false,
                    zeroline = false
                ),
            yaxis =
                Yaxis(
                    title = "Degrees",
                    showline = false
                )
        )

    lineTrace1 |> Chart.Plot |> Chart.WithLayout styledLayout |> Chart.Show
    *)
    
    let companies = 
        [
            (37.4970,  127.0266, "Samsung: 20.5%")
            (37.3318, -122.0311, "Apple: 14.4%")
            (22.5431,  114.0579, "Huawei: 8.9%")
        ]

    let options = Options(showTooltips = true, displayMode="markers")

    let map = companies |> Chart.Geo |> Chart.WithOptions options
    
    map |> Chart.Show
    // |> Chart.WithLabels ["Nom"; "Percentage"] 
    0 // return an integer exit code
