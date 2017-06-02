open System

type Calculator(s : string) =
    let mutable items = s.Split(' ')
    let mutable ans : double = Array.map (fun i -> (double i)) items |> Array.sum
    member x.Item 
        with get i = items.[i] 
        and set i v = 
                items.[i] <- v
                ans <- Array.map (fun i -> (double i)) items |> Array.sum
    member x.Result = ans

            

                        


[<EntryPoint>]
let main argv = 
    let c = Calculator("2 3 4 5 6")
    c.[3] <- (string 34)
    for i in 0 .. 4 do
        printfn "%s" c.[i]
    printfn "%f" (Math.Round (c.Result,2))
    Console.ReadKey() |> ignore
    0 // return an integer exit code
