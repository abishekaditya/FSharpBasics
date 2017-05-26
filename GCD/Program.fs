open System

let rec gcd x y =
    if y= 0 then x 
    else gcd y (x % y)

[<EntryPoint>]
let main argv = 
    gcd 1245 3455 |> printf "GCD of 1245 and 3455 is %A \n"
    Console.ReadKey() |> ignore
    0 // return an integer exit code
