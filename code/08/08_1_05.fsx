(* 08_1_05.fsx *)
open System
open System.Globalization

let (|Int|Bool|Diğer|) girdi = 
   
    let (sayıMı,değer1) = Int32.TryParse(girdi,NumberStyles.Any,null)
    let (boolMu,değer2) = Boolean.TryParse(girdi)
    if sayıMı then
        Int(değer1)
    else if boolMu then
        Bool(değer2)
    else 
        Diğer(girdi)

let SayıMıBoolMu (girdi:string) = 
    match girdi with
    | Int değer -> printfn "int, değer = %d" değer
    | Bool değer -> printfn "bool, değer = %A" değer
    | Diğer _ -> printfn "Sonuç int veya bool değil!"

// TEST
SayıMıBoolMu "12"
SayıMıBoolMu "true"
SayıMıBoolMu "Mahmut Tuncer"
