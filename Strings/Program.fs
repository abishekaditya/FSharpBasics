open System



[<EntryPoint>]
let main argv =
    
    let name = String.collect (fun c -> sprintf "%c " c) "Hello World"
    printfn "Collect: %s" name
    
    let name1 = String.concat ","  ["Abc"; "Def"; "Ghi"] 
    printfn "%s" name1

    let name2 = String.filter (fun x -> x > 'a') "Hello World"
    printfn "%s" name2

    let name3 = String.map (fun x -> if (x > 'a') then (Char.ToUpper x) else (Char.ToLower x) ) "Hello World"
    printfn "%s" name3

    let func i x = if (i > 5) then  (Char.ToUpper x) else  (Char.ToLower x)
    let name4 = String.mapi func "Hello World"
    printfn "%s" name4

    Console.ReadKey() |> ignore
    0 // return an integer exit code
