open System
open CustomEvent
    
let hallFan = Fan(Name = "Hall Fan")
hallFan.AddHandlers((fun _ -> (printfn "%s speed changed to %A" hallFan.Name hallFan.Value )))

[<EntryPoint>]
let main argv = 
    let mutable t = 0
    let timer = new Timers.Timer(500.0)
    timer.Elapsed.Add (fun ea -> printfn "%d" t; t <- t + 1)
    timer.Start()
    while t < 5 do ()
    timer.Dispose()
    printfn "Custom Handler"
    hallFan.Toggle()
    hallFan.Toggle()
    hallFan.Toggle()
    hallFan.Toggle()
    Console.ReadKey() |> ignore
    0 // return an integer exit code
