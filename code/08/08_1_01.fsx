(* 08_1_01.fsx *)

open System
open System.Globalization

let SayıMıBoolMu (girdi:string) = 
    let (sayıMı,değer1) = Int32.TryParse(girdi,NumberStyles.Any,null)
    let (boolMu,değer2) = Boolean.TryParse(girdi)

    let sayıDeğeri = if sayıMı then Some(değer1) else None
    let boolDeğer = if boolMu then Some(değer2) else None
    let sonuç = (sayıMı,boolMu,sayıDeğeri,boolDeğer )

    match sonuç with
    | (true,_,Some(değer),_) -> printfn "int, değer = %d" değer
    | (_,true,_,Some(değer)) -> printfn "bool, değer = %A" değer
    | _ -> printfn "Sonuç int veya bool değil'"
    
// TEST

SayıMıBoolMu "12"
SayıMıBoolMu "true"
SayıMıBoolMu "Mahmut Tuncer"

