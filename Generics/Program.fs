open System

type Movies = { name : string ; year : int ; rating : double}
type Actors = { name : string ; age : int ; rating : double}


[<EntryPoint>]
let main argv = 
    let movie_rating (x : ^T when ^T : (member name : string)) = x.rating
    
    printfn "%f" (movie_rating {name = "Abishek"; age = 12; rating = 4.3})
    Console.ReadKey() |> ignore
    0 // return an integer exit code
