(* 03_2_07 *)

// Çift tırnak ile metin tanımlama, unicode ve kontrol karakterleri

let metin1 = "F# ile fonksiyonel programlama"

let metin2 = "ali özg\u00FCr" 
// Çıktı
// ali özgür

let metin3 = "\'Kitap Adı\' F# ile Fonksiyonel Programlama\n \"Yazar\" Ali Özgür"
// Çıktı
(*
'Kitap Adı' F# ile Fonksiyonel Programlama
 "Yazar" Ali Özgür
*)

// Çift tırnak üçlüsü ile metin değeri tanımlama
let metin4 = """ "Kitap Adı" F# ile fonksiyonel programlama, 'Yazar' Ali Özgür """
// Çıktı
// "Kitap Adı" F# ile fonksiyonel programlama, 'Yazar' Ali Özgür 

// Çok satıra yayılmış metin
let çokSatırlıMetin = " 1, \
                        2, \
                        3, "
// Çıktı
// 1,2,3

// Verbatim metin
let metin5 = @"Yazar \ Ali Özgür. Kontrol karakterleri \r \n \t \\"
// Çıktı 
// Yazar \ Ali Özgür. Kontrol karakterlerimiz şunlar \r \n \t \\