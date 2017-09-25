(* 03_7_02.fs *)
module SanalMarket
let MarkaAdı = "Sanal Market"
let Echo x = 
    sprintf "%A" x

type Müşteri = {Ad:string;Soyad:string}

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