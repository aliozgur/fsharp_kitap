(* 08_5_03.fsx *)

// 1.YÖNTEM : Parametre Olarak Dekoratör Fonksiyonları

let pastaYap tutar = 
    sprintf "Pasta (%.2f TL)" tutar,tutar 

let isimKartıEkle f (tutar:float) = 
   let a,t = f tutar
   let ekTutar = 5.0
   
   (sprintf "%s, İsimKartı (%.2f TL)" a ekTutar,t + ekTutar) 

let meyveEkle f (tutar:float) = 
   let a,t = f tutar
   let ekTutar = 10.0
   (sprintf "%s, Meyve (%.2f TL)" a ekTutar,t + ekTutar) 

let yüzdeOnİndirimUygula f (tutar:float) = 
   let a,t = f tutar
   let indirimTutarı = t*0.1
   let indirimliTutar= t - indirimTutarı   
   (sprintf "%s, İndirim (%.2f / %%%.2f)"  a  indirimTutarı 10.0,indirimliTutar) 

// TEST
let meyveliPasta =  meyveEkle pastaYap

let isimKartlıVeMeyveliPasta =  isimKartıEkle  meyveliPasta

let indirimliİsimliVeMeyveliPasta = yüzdeOnİndirimUygula isimKartlıVeMeyveliPasta

let açıklama,tutar = indirimliİsimliVeMeyveliPasta 45.0

printfn "Tutar: %.2f TL | %s" tutar açıklama

// 2.YÖNTEM : Fonksiyonların kompozisyonu ile dekorasyon 

let yazdır input = 
    printfn "Log : %A" input
    input

// TEST
let indirimliİsimliVeMeyveliPasta' = yazdır >> indirimliİsimliVeMeyveliPasta >> yazdır
indirimliİsimliVeMeyveliPasta' 45.0
