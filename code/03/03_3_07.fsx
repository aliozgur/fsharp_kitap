(* 03_3_07.fsx *)
(* Eksik parametreli fonksiyon çağırlarına DİKKAT *)

// Fonksiyon tanımı
let sayılarıEkrandaGöster x y z = printfn " x = %d, y=%d, z=%d" x y z

// Fonksiyonu eksik iki parametre ile çağırdık.
// 2 sayısı ekranda gösterilmez bunun yerine FSI aşağıdaki gibi bir çıktı üretir
// val it : (int -> int -> unit)
// Bu çıktıya göre "sayılarıEkrandaGöster 2" çağırısı iki int girdi
// parametresi alıp int tipinden bir sonuç döndüren bir fonksiyon döndürür
// Ekrana hiç birşey basılmaz
sayılarıEkrandaGöster 2