(* 03_3_08.fsx *)


let ekle x y = x + y

// İmzası val birEkle : (int -> int) olur
// int çıktı veren ve tek int girdi alan bir fonksiyon
let birEkle = ekle 1
birEkle 42

let çarp x y = x * y
// İmzası val ikiİleÇarp : (int -> int) olur
// int çıktı veren ve tek int girdi alan bir fonksiyon
let ikiİleÇarp = çarp 2
ikiİleÇarp 42

