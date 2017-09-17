(* 03_2_4c.fsx *)

// Operatörler ile karşılaştırma
let kırkİkiİleKarşılaştır x = 
    if x > 42 then 
        printfn " %d > 42" x
    else if x < 42 then
        printfn " %d < 42" x 
    else 
        printfn " %d = 42" x 
    
    
// compare fonksiyonu ile karşılaştırma
let kırkİkiİleKarşılaştır' x = 
    let sonuç = compare x 42

    if sonuç = 0 then
        printfn " %d = 42" x
    else if sonuç = 1 then
        printfn " %d > 42" x
    else
        printfn " %d < 42" x

kırkİkiİleKarşılaştır 43
kırkİkiİleKarşılaştır 41
kırkİkiİleKarşılaştır 42

kırkİkiİleKarşılaştır' 43
kırkİkiİleKarşılaştır' 41
kırkİkiİleKarşılaştır' 42