open Weapon
open Armour
open System

let Mace = forgeWeapon "2 handed mace" 23 12
let Sword = forgeWeapon "1 handed sword" 13 22
let FireCloak = Cloak(16,12,15)
let IronArmour = Armour(26,12)

[<EntryPoint>]
let main argv = 
    printfn "%A" Mace
    printfn "%A" Sword
    printfn "Fire Cloak : magic %d, Defence %d and Speed %d" FireCloak.Magic FireCloak.Defense FireCloak.Speed
    printfn "Iron Armour : Defence %d and Speed %d" IronArmour.Defense IronArmour.Speed
    Console.ReadKey() |> ignore
    0 // return an integer exit code
