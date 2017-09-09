(* 03_3_06.fsx *)

// Ana fonksiyon
let üçSayıyıÇarp x =
    // Ana fonksiyon içinde yerel fonksiyon
    let çarp' y = 
        // Yerel fonksiyon içinde yerel fonksiyon
        let çarp'' z = x * y * z  
        // Yerel fonksiyon kendi içindeki yerel fonksiyonu döndürür
        çarp''
    // Ana fonksiyon kendi içindeki yerel fonksiyonu döndürür
    çarp'

// İlk çağırı, val çarp' : (int -> int -> int) imzalı 
// fonksiyon döndürür. çarp' 3 değerini içinde barındırır
let çarp' = üçSayıyıÇarp 3

// İkinci çağırı. val çarp'' : (int -> int) imzalı
// fonksiyon döndürür. çarp'' hem 3 hem de 4 değerini içinde barındırır
let çarp'' = çarp' 4

// Son çağırı. çarp'' 3 ve 4 değerini içinde barındırıyor
// 5 değeri de verilince sonuç olarak 120 hesaplanıyor
çarp'' 5

// Üç parametreli normal bir fonksiyon tanımı
let üçSayıyıÇarp' x y z = x * y * z



