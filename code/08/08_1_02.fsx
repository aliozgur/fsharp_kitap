(* 08_1_02.fsx *)

open System
let (|SesliHarfVarMı|) girdi = 
    let sesliHarfler = 
        ['a';'e';'ı';'i';'o';'ö';'u';'ü'] 
        |> Set.ofList    
    
    let karakterler = 
        (girdi :> char seq) 
        |> Set.ofSeq 
        |> Set.map(fun c -> System.Char.ToLower(c))
    
    karakterler 
    |> Set.intersect (sesliHarfler)
    |> Set.isEmpty
    |> not

    
let KontrolEt metin = 
    match metin with
    | SesliHarfVarMı true -> printfn "Sesli harf içeriyor. %s " metin
    | SesliHarfVarMı false -> printfn "Sesli harf içermiyor. %s" metin

// TEST

KontrolEt "Mahmut Tuncer"
KontrolEt "Cyndy"