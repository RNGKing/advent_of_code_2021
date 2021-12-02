// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open Library.AdventOne

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let holding = readFileToInts "/Users/patrickphillips/repo/dotnet_projects/fsharp/advent_of_code_2021/advent_of_code_2021_fsharp/src/App/bin/Debug/net5.0/data.dat"
    printfn "Found greaters : %i" holding
    0 // return an integer exit code