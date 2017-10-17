(* 04_5_01.fsx *)

let karşılaştır birinci ikinci birinciBüyükse büyükVeyaEşitlerse =
    if birinci > ikinci then
        printfn "%d > %d" birinci ikinci
        birinciBüyükse
    else
        printfn "%d > %d" ikinci birinci    
        büyükVeyaEşitlerse
       

let topla x y = 
    let t = x + y
    printfn " %d + %d = %d" x y t
    t

// TEST

// İlk çağrı
karşılaştır 4 3 (printfn "birinci büyük") (printfn "ikinci büyük")

// İkinci çağrı 
karşılaştır 4 3 (topla 1 0) (topla -1 0)
