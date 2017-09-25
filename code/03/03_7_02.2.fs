(* 03_7_02.2.fs *)

// --------- 1. Yöntem ---------
namespace SanalMarket1

// Tip tanımı
type MüşteriTipi = {Ad:string;Soyad:string}

// Tip adını taşıyan modül
module Müşteri = 
   // Tip ile ilgili işlem yapan fonksiyon
   let oluştur ad soyad =  
    {Ad=ad;Soyad=soyad}

