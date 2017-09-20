(* 03_3_13.fsx *)

// -------------------  HATALI TANIM  ------------------- 
(* 
    Aşağıdaki karşılıklı öz yinelemeli fonksiyon tanımı.
    hatalıdır. Derleyici bu fonksiyonların tanımını 
    derlemez hata verir.
*)

// A fonksiyonu
let A() = 
    B()

// B fonksiyonu
let B() = 
    A()

(* 03_3_13.fsx *)
// -------------------  DOĞRU TANIM  ------------------- 
let rec Çift x = 
    if x = 0 then
        true
    else
        Tek (x-1)
and Tek x = 
    if x = 0 then 
        false
    else 
        Çift (x-1)

// TEST
Çift 1
Çift 2

Tek 3
Tek 4