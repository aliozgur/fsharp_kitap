(* 08_5_07.fsx *)
open System
let böl (bölünen:float) (bölen:float) = 
    if bölen = 0.0 then
        raise (DivideByZeroException("Sıfıra bölme geçersiz"))
    else
        bölünen / bölen

let böl' (bölünen:float) (bölen:float) = 
    if bölen = 0.0 then
        None
    else
        Some(bölünen / bölen)

let böl'' bölenSıfırİse başarılı (bölünen:float) (bölen:float) = 
    if bölen = 0.0 then
        bölenSıfırİse()
    else
        let sonuç = bölünen / bölen
        başarılı(sonuç)

// TEST
let hataFırlat() = raise ( System.DivideByZeroException("Sıfıra bölme geçersiz") )
let hataYaz() = printfn "Sıfıra bölme geçersiz'"

let ekranaYaz s = printfn "Sonuç:%f" s


let bölHataAtVeyaEkranaYaz = böl'' hataFırlat ekranaYaz
let bölVeEkranaYaz = böl'' hataYaz ekranaYaz



bölHataAtVeyaEkranaYaz 12.0 2.0
bölHataAtVeyaEkranaYaz 12.0 0.0

bölVeEkranaYaz 12.0 2.0
bölVeEkranaYaz 12.0 0.0

let none() = None
let some f = Some(f)
böl'' none some 12.0 2.0
böl'' none some 12.0 0.0

