(* 08_5_02.fsx *)

type IIndirimStratejisi = float -> float

let indirimUygula (indirim:IIndirimStratejisi) değerler = 
    let indirimliFiyatHesapla x = x - indirim x
    değerler |> List.map indirimliFiyatHesapla


let yüzdeElliİndirim x =  x * 0.5
let yüzdeYirmibeşİndirim x = x * 0.25

// TEST

[1.0..100.0] 
|> indirimUygula yüzdeElliİndirim

[1.0..1.0..100.0] 
|> indirimUygula yüzdeYirmibeşİndirim
