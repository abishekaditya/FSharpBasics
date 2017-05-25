open System

let main x y =
    x + y

[<EntryPoint>]
let mine argv = 
    let r = main 20 15
    printfn "%i" r
    Console.ReadLine() |> ignore
    0