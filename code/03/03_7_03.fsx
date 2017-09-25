(* 03_7_03.fsx *)
#load "03_7_02.fs"

// SanalMarket modülünü erişime açıyoruz
open SanalMarket

printfn "Marka Adı = %s" MarkaAdı
Echo "Sanal Market Client"

let müşteri = {Ad="Mahmut";Soyad="Tuncer"}

//SanalMarket üst modülü altındaki 
//  Sepet iç modülü 
//erişime açıyoruz
open SanalMarket.Sepet
let iPhone7 = {Ad="iPhone 7";Fiyat=5099M}

//SanalMarket üst modülü altındaki 
//  Sepet iç modülünün altındaki 
//      Utils iç modülünü 
//erişime açıyoruz
open SanalMarket.Sepet.Utils

let iPhoneX = ürünOluştur "iPhone X" 6099M

// Değer kavrama ile ürünleri oluşturup 
// listeyi |> ile sepetOluştur fonksiyonuna aktarıyoruz

[
    for i in 3..6 do
        yield {Ad= sprintf "iPhone %d" i;Fiyat= decimal(i) * 1000M}
] |> sepetOluştur "Mahmut" "Tuncer"
