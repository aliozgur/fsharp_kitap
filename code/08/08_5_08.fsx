(* 08_5_08.fsx *)

let f x = Some(x * 10)
let g x = if x = 100 then None else Some(x * 2)
let h x = Some(x * 3)




let işlemYap girdi = 
    let x = f girdi
    if x.IsSome then
        let y = g x.Value 
        if y.IsSome then
            let z = h y.Value
            if z.IsSome then
                z
            else 
                None
        else
            None
    else 
        None




let ifSomeDo f girdi = 
    if Option.isSome(girdi) then
        f girdi.Value
    else 
        None


let işlemYap' girdi = 
    f girdi 
    |> ifSomeDo g
    |> ifSomeDo h

//TEST
işlemYap' 10


