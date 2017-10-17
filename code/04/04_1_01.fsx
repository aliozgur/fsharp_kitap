(* 04_1_01.fsx *)

let üsAl x y = 
    match y with 
    | 2 -> x * x
    | 3 -> x * x * x
    | 4 -> x * x * x
    | _ -> x

// TEST
üsAl 2 2 
üsAl 2 3 
üsAl 2 4
üsAl 2 5

let büyükKüçükSıfırDenetimi sayı = 
    match sayı with
    | x when x = 0 -> printfn "Değer sıfıra eşit"
    | x when x > 0 -> printfn "Değer sıfırdan büyük ve %d"  x
    | x when x < 0 -> printfn "Değer sıfırdan küçük ve %d"  x
    | _ -> printfn "Bu mükün değil ama derleyici mutlu olsun"

// TEST 
büyükKüçükSıfırDenetimi 4


let metniTamSayıyaÇevir metin =     
    let sonuç = System.Int32.TryParse(metin,System.Globalization.NumberStyles.Any,null)
    // sonuç : bool * int 

    match sonuç with
    |(true,sayı) -> Some(sayı)
    |(false,_) -> None

// TEST 
metniTamSayıyaÇevir "A"
metniTamSayıyaÇevir "-42"
metniTamSayıyaÇevir "-42"

type Kişi = {Ad:string;Soyad:string}
let kişiyiTanımla kişi = 
    match kişi with
    | {Ad=ad;Soyad=soyad} when soyad = "Özgür" -> printfn "Kişi = '%s %s', Ailesi = %s " ad soyad soyad    
    | {Ad=ad;Soyad="Oyuktaş"} -> printfn "Kişi = '%s %s', Ailesi = %s " ad "Oyuktaş" "Oyuktaş"  
    | _ -> printfn "%s %s, seni çıkaramadım!" kişi.Ad kişi.Soyad

let arda = {Ad="Arda";Soyad="Özgür"}
let sarp = {Ad="Sarp";Soyad="Oyuktaş"}
let mahmut = {Ad="Mahmut";Soyad="Tuncer"}

// TEST
kişiyiTanımla arda
kişiyiTanımla sarp
kişiyiTanımla mahmut


let tekMiÇiftMi x = 
    match x with
    | 0 -> printfn "Sayı sıfır! Çift veya tek değil"
    | a when a % 2 = 0 -> printfn "%d bir çift sayıdır" a
    | _ -> printfn "%d bir tek sayıdır" x
   
// TEST
tekMiÇiftMi 0
tekMiÇiftMi 42
tekMiÇiftMi -3


let tekMiÇiftMi' x = 
    match x with
    | _ -> printfn "%d bir tek sayıdır" x
    | 0 -> printfn "Sayı sıfır! Çift veya tek değil"
    | a when a % 2 = 0 -> printfn "%d bir çift sayıdır" a
   
// TEST
tekMiÇiftMi' 0
tekMiÇiftMi' 42
tekMiÇiftMi' -3


let büyükKüçükSıfırDenetimi' sayı = 
    match sayı with
    | x when x > 0 -> printfn "Değer sıfırdan büyük ve %d"  x
    | x when x < 0 -> printfn "Değer sıfırdan küçük ve %d"  x

// TEST 
büyükKüçükSıfırDenetimi' 4
büyükKüçükSıfırDenetimi' 0 //MatchFailureException
