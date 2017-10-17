(* 03_3_05.fsx *)

// İki parametreli fonksiyon tanımı
let ikiDeğeriEkranadaGöster x y = 
    printfn "Değerler x=%d, y=%d" x y

// Test
ikiDeğeriEkranadaGöster 1 2

// Tek parametreli fonksiyon olarak tanımlama
let tekDeğeriEkrandaGöster x = 
    // Yerel fonksiyon
    let _ikiDeğeriEkrandaGöster y =
         printfn "Değerler x=%d, y=%d" x y
    
    // Yerel fonksiyonu ana fonksiyonun çıktısı olarak dön
    _ikiDeğeriEkrandaGöster

// Test

// Aşağıdaki ifadenin sonucu (int->unit) imzalı bir fonksiyon
// 1 parametresi tekDeğeriEkrandaGöster çıktısı olan fonksiyona gömülür 
let  ikiDeğeriEkrandaGöster' = tekDeğeriEkrandaGöster 1

// ikiDeğeriEkrandaGöster' tek parametre alan bir fonksiyon
// 2 parametresi ile çağırırsak sonuç ikiDeğeriEkranadaGöster ile aynı olur
ikiDeğeriEkrandaGöster' 2