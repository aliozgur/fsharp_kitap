(* 03_7_02.1.fs *)

namespace SanalMarket

type Müşteri = {Ad:string;Soyad:string}

module Genel = 
    let MarkaAdı = "Sanal Market"
    let Echo x = 
        sprintf "%A" x

// SanalMarket modülü altında alt seviye modül
module Sepet = 
    type Ürün={Ad:string;Fiyat:decimal}
    type Sepet = {Müşteri:Müşteri; Ürünler: Ürün list}

    // Sepet alt modülü altında başka bir alt modül
    module Utils = 
        let ürünOluştur ad fiyat = 
            {Ad="iPhone X";Fiyat=fiyat}
        let sepetOluştur ad soyad ürünler = 
                {Müşteri={Ad=ad;Soyad=soyad}; Ürünler= ürünler}