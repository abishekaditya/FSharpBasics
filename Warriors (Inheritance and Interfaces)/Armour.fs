module Armour

type Armour(def : int, spd : int) = 
    member x.Defense = def
    member x.Speed = spd
 
 type Cloak(mgc : int, def, spd) =
    inherit Armour(def,spd)
    member x.Magic = mgc