open System

[<FlagsAttribute>]
type DaysOfWeek =
    | monday = 1
    | tuesday = 2
    | wednesday = 4
    | thursday = 8
    | friday = 16
    | saturday = 32
    | sunday = 64

let toUpper (s : string) = 
    (s.Substring(0,1).ToUpper() + s.Substring(1).ToLower())

let whichday (num : int32) =
   let weekend = DaysOfWeek.saturday ||| DaysOfWeek.sunday
   match num with
   | 1 | 2 | 4 | 8 | 16 | 32 | 64 -> Enum.GetName(typeof<DaysOfWeek>, num) |> toUpper
   | weekend -> "Weekend"
  
    


[<EntryPoint>]
let main argv = 
    printf "%s\n" (whichday 4)
    printf "%s\n" (whichday 96)
    Console.ReadKey() |> ignore
    0 // return an integer exit code
