(* 03_3_09.fsx *)


// Basit bir "kare" fonksiyonu
let kare x = x * x


// List.map fonksiyonun ilk parametresi "kare" fonksiyonu
// ikinci parametresi olan liste verilmemiş

// kareleriniAl imzası şöyle olur 
// "val kareleriniAl : (int list -> int list)"
// kareleriniAl girdi olarak int değer listesi alıp çıktı olarak 
// int değer listesi döndüren bir fonksiyondur
let kareleriniAl = List.map kare 

// "kareleriniAl" [1..10] listesi parametresi ile çağırılır 
kareleriniAl [1..10]

