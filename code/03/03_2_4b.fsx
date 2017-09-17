(* 03_2_4b.fsx *)

open System

// İşaretsiz 16-bit tam sayı maksimum değeri 65,535
let işaretsiz_16_bit = UInt16.MaxValue

// İşaretli 16-bit tam sayıya dönüştürelim
// Değer aşımı nedeni ile sonuç -1s olacaktır.
// Çünkü, işaretsi 65,535 değeri işaretli tam sayı aralığı dışında
let işaretli_16_bit = int16 işaretsiz_16_bit

// Değer aşımlarında hata üretilmesi için Checked modülüne referans veriyoruz
open Checked

// Hata üretilir çünkü işaretsiz 65,535 değeri işaretli değer aralığının dışında
let işaretli_16_bit_checked = int16 işaretsiz_16_bit
