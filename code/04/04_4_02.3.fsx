(* 04_4_02.3.fsx *)

#load "04_4_02.1.fs"
#load "04_4_02.2.fs"

// TEST
open Okul.Model
open Okul.Ekstralar

// Kişi tipinden değer tanımlıyoruz
let arda = {Ad="Arda";Soyad="Özgür"}

// Öğrenci tipinden değer tanımlıyoruz
let öğrenci = {KişiBilgisi=arda;Numara=1001}

öğrenci.TamAdı
