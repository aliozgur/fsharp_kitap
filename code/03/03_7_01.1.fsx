(* 03_7_01.1.fsx *)

// Kişi kayıt tipi tanımı
type Kişi = {Ad:string;Soyad:string}

// Kişi bilgisi fonksiyonu tanımı
let kişiBilgisi (k:Kişi) = 
    sprintf "%s %s" k.Ad k.Soyad

// Kişi tipinden değer
let kişi = {Ad="Arda";Soyad="Özgür"}

// kişi değerini ekrana yazdırma
printfn "Kişi bilgisi : %s" (kişiBilgisi kişi)




