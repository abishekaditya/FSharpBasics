open System

let createDisposable name = 
    printfn "Creating %s" name
    { new IDisposable with member x.Dispose() = printfn "Disposing %s" name }

let main = 
    use obj = createDisposable "Hey"
    for i in [1..2] do
        use nested = createDisposable (sprintf "Inner %i" i)
        printfn "Inner %i" i
    printfn "Leaving Inner"
    ()

open System.IO

let writeToFile file (str : string) =
    use fs = new FileStream(file, FileMode.CreateNew, FileAccess.Write)
    let array = str.ToCharArray()
    let barr = Array.map (fun x -> byte x) array
    fs.Write(barr, 0, barr.Length)
    
[<EntryPoint>]
let run args =
    let x = main |> ignore
    printfn "Done"
    writeToFile "D" "ABCDEFGH"
    Console.ReadLine() |> ignore
    0