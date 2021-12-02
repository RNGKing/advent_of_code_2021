namespace Library




module AdventOne = 
    open System
    open System.IO

    let compareSequencePairs input =
        let listOfInts = Seq.toList input
        let mutable sum = 0
        for i = 1 to listOfInts.Length - 1 do
            if listOfInts.[i] >= listOfInts.[i - 1] 
            then sum <- sum + 1
        sum

    let comparitor left right =
        if right < left then printfn "false : %i, %i" right left
        

    let compareInts (input : int * int) =
        match input with
        | (left, right) -> 
            // comparitor left right
            left > right 

    let buildTripletWise (input : seq<int>) =
        let mutable list = []
        for i = 0 to Seq.length input - 3 do
            let first =  input |> Seq.tryItem i
            let second = input |> Seq.tryItem (i + 1)
            let third = input |> Seq.tryItem (i + 2)
            //printfn "entry found %i, %i, %i, %i" first.Value second.Value third.Value (first.Value+second.Value + third.Value)
            list <- [first.Value; second.Value; third.Value] :: list
        list

    let printOutLengthOfTripletGroupings (input : list<list<int>>) = 
        printfn "Length of triplets %i" input.Length
        input

    let printOutTuples (input : int * int) =
        match input with
        | (left, right) -> printfn "%i, %i" left right

    let readFileToInts filePath =
        File.ReadAllLines filePath
        |> Seq.map Int32.Parse
        |> buildTripletWise
        |> printOutLengthOfTripletGroupings
        |> Seq.map Seq.sum  
        |> Seq.pairwise
        |> Seq.map compareInts
        |> Seq.filter (fun input -> input)
        |> Seq.length 