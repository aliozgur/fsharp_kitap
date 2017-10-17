(* 01_1_10.fsx *)
open System

// Değişken
let mutable sayı = 42
sayı <- 43

let dizi = [|1..100|]
// for ve  if/else yapıları 
for i in dizi do
    if i % 2 = 0 then
        printfn "Çift Sayı = %d" i
    else
        printfn "Tek Sayı = %d" i

// yan etkili fonksiyon
// printfn'in yan etkisi terminale metin yazdırmasıdır
printfn "Sayının değeri = %d" sayı

// System.Int32 .NET'in sağladığı tam sayı tipidir
// Aşağıdaki ifade ile System.Int32 tipi için 
// ÇiftMi isimli ek metod tanımı
type System.Int32 with
    member this.ÇiftMi() = this % 2 = 0

// System.Int32 tipinden iki sayı
let çiftSayı:System.Int32 = 12 
let tekSayı:System.Int32 = 11 

// sayıların çift olup olmadığını kontrolü
çiftSayı.ÇiftMi()
tekSayı.ÇiftMi()

// Nesne tabanlı programlama dillerindeki gibi sınıf tanımları
[<AbstractClass>]
type Şekil = 
    abstract member Renk : string
    abstract AlanHesapla : unit -> float 
