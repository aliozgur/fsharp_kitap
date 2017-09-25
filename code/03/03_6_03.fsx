(* 03_6_03.fsx *)

// Kişi isimli kayıt tipi
type Kişi = {Ad:string;Soyad:string}

// kişi1, kişi2 ve kişi3 değerler
let kişi1 = {Ad="Ali";Soyad="Özgür"}
let kişi2 = {Ad="Ali";Soyad="Özgür"}
let kişi3 = kişi1

let kişi4 = {Ad="Arda";Soyad="Özgür"}


printfn "kişi1 = kişi2 : %b" (kişi1 = kişi2)
// Çıktı : kişi1 = kişi2 : true

printfn "kişi1 = kişi3 : %b" (kişi1 = kişi3)
// Çıktı : kişi1 = kişi3 : true

printfn "kişi2 = kişi3 : %b" (kişi2 = kişi3)
// Çıktı : kişi2 = kişi3 : true

printfn "kişi1 = kişi4 : %b" (kişi1 = kişi4)
// Çıktı : kişi1 = kişi4 : false
