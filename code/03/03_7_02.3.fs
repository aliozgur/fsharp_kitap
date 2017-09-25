(* 03_7_02.3.fs *)

// --------- 2. Yöntem ---------
namespace SanalMarket2

// Tipin adını taşıyan modül
module Müşteri = 
    // Gerçek tip tanımı basit bir isim ile yapılıyor
    type T = {Ad:string;Soyad:string}
    
    // Tip ile ilgili işlem yapan fonksiyon
    let oluştur ad soyad =  
        {Ad=ad;Soyad=soyad}

