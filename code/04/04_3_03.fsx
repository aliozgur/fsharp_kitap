(* 04_3_03.fsx *)

(*
    İPUCU-1
*)
// Hatalı Kullanım! 
// Etiket isimleri büyük harfle başlamalı.
(*
type SıcaklıkDerecesi = 
    | fahrenayt
    | celcius
*)
type SıcaklıkDerecesi = 
    | Fahrenheit
    | Celcius
(*
    İPUCU-2
*)
// Kendi tanımladığımız veya sistem tanımlı
// tipleri etiket adı olarak kullanabiliriz.
type Kişi = {Ad:string;Soyad:string}
type Kullanıcı = 
    | Kişi of Kişi
    | Öğrenci of Kişi
    | Personel of Kişi

(*
    İPUCU-3
*)
// Hatalı Kullanım!
// Etiktlerin tipi yerinde (inline) olarak tanımlanamaz
(*
type Enstrüman  = 
    | Gitar of ( | Elektrikli | Akustik )
    | Piyano of ( { Marka:string; Model:string } )

*)
type GitarTipi = Elektrikli | Akustik
type MarkaModelBilgisi = { Marka:string; Model:string } 
type Enstrüman  = 
    | Gitar of GitarTipi
    | Piyano of MarkaModelBilgisi

(*
    İPUCU-4
*)
// Tek seçenekli bileşimler tanımlanabilir.
// Bu yöntem genelde standard tiplerin iş terimleri 
// olarak modellenmesi amacıyla kullanılıyor

type Int32 = Int32 of int
type Metin = Metin of string

let sayı = Int32 12
let metin = Metin "F# bir harika dostum"
