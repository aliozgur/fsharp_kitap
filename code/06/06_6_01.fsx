(* 06_6_01.fsx *)

let çifMiTekMi x = 
    if x % 2 = 0 then
        printfn "%d çift bir sayıdır" x
        true
    else 
        printfn "%d tek bir sayıdır" x
        false

çifMiTekMi 12


let sayıBirVeyaİkiMi x = 
    if x = 1 then
        printfn "Değer %d" x
        true    
    else if x = 2 then
        printfn "Değer %d" x
        true        
    else
        printfn "Değer %d" x
        false    

[1..5] |> List.map sayıBirVeyaİkiMi

let sayıBirVeyaİkiMi' x = 
    if x = 1 || x = 2 then
        printfn "Değer %d" x
        true        
    else
        printfn "Değer %d" x
        false    

[1..5] |> List.map sayıBirVeyaİkiMi'


let tamKareköküVarMı x = 
    if sqrt(x) % 1.0 = 0.0 then
        true
    else
        false

[1.0..10.0] |> List.map tamKareköküVarMı


let tamKareköküVarMı' x = 
    let mutable sonuç = false
    if sqrt(x) % 1.0 = 0.0 then
        sonuç <- true
    
    sonuç

[1.0..10.0] |> List.map tamKareköküVarMı'
