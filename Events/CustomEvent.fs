module CustomEvent


type FanState =
   | Off = 0
   | Low = 1
   | Med = 2
   | High = 3

type Fan() =
    let toggleEvent = Event<_>()
    let mutable value = FanState.Off
    member val Name = "" with get, set 
    
    member x.Value 
        with get() = value

    member x.AddHandlers(r) = 
        Event.add r toggleEvent.Publish

    member x.Toggle() =
        match value with
        | FanState.Off -> value <- FanState.Low
        | FanState.Low -> value <- FanState.Med
        | FanState.Med -> value <- FanState.High
        | _ -> value <- FanState.Off
        toggleEvent.Trigger()
