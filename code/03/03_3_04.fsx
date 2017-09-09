(* 03_3_04.fsx *)

// küp fonksiyonu ana fonksiyonumuz
let küp x = 
    // küp içinde kare isimli yerel bir fonksiyon tanımlıyoruz
    let kare x = 
        printfn "Yerel fonksiyon : Kare hesaplanıyor"
        x * x
    printfn "Ana fonksiyon : Küp hesaplanıyor"
    // yerel küp fonksiyonunu ana fonksiyon içinden çağırıyoruz
    x * (kare x)

küp 2

//Hatalı kullanım, kare fonksiyonu küp içindeki yerel bir fonksiyon
//kare 2

