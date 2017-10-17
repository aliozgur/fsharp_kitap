(* 08_1_03.fsx *)
open System
open System.Globalization

let (|Int|_|) girdi = 
    let (sonuç, değer) = Int32.TryParse(girdi,NumberStyles.Any,null)
    if sonuç then
        Some(değer)
    else None

let TamSayıMıKontrolEt girdi = 
    match girdi with
    | Int a -> printfn "Sonuç bir tam sayı, değer = %d" a
    | _ -> printfn "Sonuç bir tam sayı değil"

// TEST
TamSayıMıKontrolEt "12"
TamSayıMıKontrolEt "Mahmut"