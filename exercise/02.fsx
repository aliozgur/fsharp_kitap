(* ALIŞTIRMA-2 *)

type Option'<'a> = 
    | None'
    | Some' of 'a
    with

    member this.isNone =  
        match this with
        | None' -> false
        | _ -> true

    member this.isSome =  
        match this with
        | Some' a -> true
        | _ -> false

    member this.getValue() = 
        match this with
        | None' -> failwith "Opsiyonun değeri belli değil"
        | Some' a -> a
    
// TEST

open System
type Kişi = {Ad:string;Soyad:string;DoğumYılı:Option'<int>}

let arda = {Ad="Arda";Soyad="Özgür";DoğumYılı=None'}
let sarp = {Ad="Sarp";Soyad="Oyuktaş";DoğumYılı=Some' 2010}


