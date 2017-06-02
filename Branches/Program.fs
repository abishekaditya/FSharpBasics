open System

[<EntryPoint>]
let main argv = 
    
    let x = 
        if (5 > 3) then
            "OOH"
        elif (5 = 3) then
            "NaH"
        else
            "CoH"
    printfn "%s" x
    Console.ReadKey() |> ignore
    0 // return an integer exit code
