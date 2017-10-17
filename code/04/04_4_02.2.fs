(* 04_4_02.2.fs *)

module Okul    
    module Ekstralar = 
        open Okul.Model // Öğrenci tipine erişim için gerekli

        // Öğrenci tipi için yeni üye alan tanımı
        type Öğrenci with
            member this.TamAdı =
               sprintf "%s %s" this.KişiBilgisi.Ad this.KişiBilgisi.Soyad