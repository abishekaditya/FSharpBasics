open System

let fizzbuzz x =
    [1..x] 
    |> Seq.map (function
        | x when x%5=0 && x%3=0 -> "FizzBuzz"
        | x when x%3=0 -> "Fizz"
        | x when x%5=0 -> "Buzz"
        | x -> string x)
    |> Seq.iter (printfn "%s")

[<EntryPoint>]
let main argv = 
    fizzbuzz 100
    Console.ReadKey() |> ignore
    0 // return an integer exit code
