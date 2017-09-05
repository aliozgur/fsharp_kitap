(* 01_1_02.fsx *)

// Süslü parantez, parantez veya noktalı virgüle ihtiyacınız yok
// Kare fonksiyonu tanımı
let kare x = x * x 

// Liste tanımlamak çok basit
// 1 ile 10 arasındaki sayıları barındıran liste
let sayılar = [1..10] 

// Tek satırda listedeki sayıların karesini alıp yeni bir liste üretebilirsiniz
let kareler = sayılar |> List.map kare

// Girintiler ile belirlenen kod blokları
let tekMiÇiftMi x = // Fonksiyon tanımı başlangıcı
    // Fonksiyonun içi
    match x with
    | a when a <= 0 -> failwith "Değer sıfırdan büyük olmalı" 
    | a when a % 2 = 0 -> true
    | _ -> false
    // Fonksiyonun sonu

// Yeni bir kod bloğu
tekMiÇiftMi 12
