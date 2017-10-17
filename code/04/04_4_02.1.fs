(* 04_4_02.1.fs *)
module Okul

module Model = 
    type Kişi = {Ad:string;Soyad:string}
    type Öğrenci = {KişiBilgisi:Kişi;Numara:int}