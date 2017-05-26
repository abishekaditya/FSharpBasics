open System

[<EntryPoint>]
let main argv = 
    for i = 0 to 6 do printf "%i\n" (i*i)
    for i = 15 downto 5 do printf "%i " (pown i 2)
    let mutable i = 2
    printf "\n"
    while i < 20 do
        printf "%i" i
        i <- i + 1
    Console.ReadKey() |> ignore
    0 // return an integer exit code
