(* 04_2_02.fsx *)

// Üst seviye modül
module Model 

// 1. alt modül
module Okul =  
    type Kişi = {Ad:string;Soyad:string;DoğumYılı:int option}

    type Öğrenci = { 
        KişiselBilgiler: Kişi
        Numara: int
        }

// 2. alt modül
module Sirket = 
    type Kişi = {Ad:string;Soyad:string;DoğumYılı:int option}

// TEST
open Okul
open Sirket

let arda = {Okul.Ad="Arda";Soyad="Kişi";DoğumYılı=Some(2008)}
let ali = {Sirket.Ad = "Ali";Soyad="Özgür";DoğumYılı=None}
let öğrenci = {KişiselBilgiler=arda;Numara=1}

let sarp : Okul.Kişi = {Ad="Sarp";Soyad="Oyuktaş";DoğumYılı=Some(2010)}
let öğrenci' = {KişiselBilgiler=sarp;Numara=2}

