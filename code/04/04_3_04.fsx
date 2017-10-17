(* 04_3_04.fsx *)

type Ebeveyn = 
    | Anne of Kişi
    | Baba of Kişi
and Kişi = 
    | AdSoyad of string
    | AdSoyadVeEbeveyn of string * Ebeveyn

let ali = Baba(AdSoyad "Ali Özgür")
let arda = AdSoyadVeEbeveyn("Arda Özgür",ali)