(* 05_2_01.fsx *)

let dizi1 = [|1;2;3|]

let dizi2 = [|
    1
    2
    3|]

// elemanları int tipinden olan dizi
let dizi1': int[] = [|1;2;3|]

// elemanları string tipinden olan dizi
let dizi2': string[] = [|
    "1"
    "2"
    "3"|] 

let boşDizi = [| |]

// Elemanları 1 ile 10 arasındaki sayılar olan dizi
let dizi3 = [|1..10|]

// Elemanları 1 ile 20 arasında olan
// 1'den itibaren 2'şer artan sayılar
// olan dizi
let dizi4 = [|1..2..20|]

// Elemanları 1 ile 20 arasında olan
// 1'den itibaren 0.5'er artan sayılar
// olan dizi
let dizi5 = [|1.0..0.5..20.0|]

// Elemanları 100 ile 0 arasında 
//2'şer azalan sayılar olan dizi
let dizi6 = [|100..-2..0|]

(* 03_5_04.fsx *)

let sayı = 2.0

// --- DEĞER KAVRAMA İLE DİZİ OLUŞTURMA ---
let dizi = [|
    yield sayı // sayının kendisi
    yield sayı ** 2.0 // sayının karesi
    yield sayı ** 3.0  // sayının küpü
|]


// Dizideki sayıların karesini liste olarak
// olarak döndüren fonksiyon.
// Dizinin ilk yarısında çift sayıların karesi,
// ikinci kısmında da tek sayıların karesi yer alır
let kareleriAl x = 
    [|
        // yerel kare fonksiyonu
        let kare m = m * m
        
        // Çift sayıların karesi
        for i in x do
          if i % 2 = 0 then
            yield kare i
        
        // Tek sayıların laresi
        for i in x do
         if i % 2 = 1 then
            yield kare i
    |]

kareleriAl [|1..10|]


// Dizi elemanlarının değerleri değiştirilebilir
let asalSayılar = [|1;3;5;7;11|]
for i in 0..4 do
    // i. elemanın değerini -1 ile çarparak değiştir
    asalSayılar.[i] <- asalSayılar.[i] * -1

// ---- KESİT ALMA ----
let çiftSayılar = [|2..2..20|]
//[|2; 4; 6; 8; 10; 12; 14; 16; 18; 20|]

let  onİkiVeOnSekizArasındakiler= çiftSayılar.[5..8]
//[|12; 14; 16; 18|]

let dörttenBüyükler = çiftSayılar.[2..]
//[|6; 8; 10; 12; 14; 16; 18; 20|]

let onDörttenKüçükler = çiftSayılar.[..5]
//[|2; 4; 6; 8; 10; 12|]

let çiftSayılar' = çiftSayılar.[*]
//[|2; 4; 6; 8; 10; 12; 14; 16; 18; 20|]