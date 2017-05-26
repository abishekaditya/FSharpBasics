open System

type Tank(?max : int) =
    let maxi = (defaultArg max 100)
    member x.Fill ?stop =
        printf "%s"  <| match (defaultArg stop 100) with
                         | 100 ->  "Filled entirely \n"
                         | stop -> sprintf "Filled to %s\n" (( (float stop) / (float maxi)).ToString("P2"))



[<EntryPoint>]
let main argv = 
    let a = Tank(200)
    a.Fill(80)
    a.Fill()
    let b = Tank()
    b.Fill(20)
    b.Fill()
    Console.ReadKey() |> ignore
    0
