module Weapon

type IWeapon =
    abstract Description : string with get
    abstract Power : int with get
    abstract Speed : int with get

let forgeWeapon desc pow spd = 
    { new System.Object() with
        override x.ToString() = (sprintf "%s : power %d and speed %d" desc pow spd)

      interface IWeapon with
            member x.Description with get() = desc
            member x.Power with get() = pow
            member x.Speed with get() = spd
    }

