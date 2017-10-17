(* 04_1_04.fsx *)
open System

// İstisna fırlata fonksiyon
let istisnaFırlat x m= 
    match x with
    | 1 -> raise (ArgumentException(m))
    | 2 -> raise (InvalidOperationException(m))
    | _ -> failwith m


// Desen eşleme kullanarak ekrana yazdıran hata bilgisi yazan fonksiyon
let istisnaYazdır no mesaj = 
    try
        printfn "İstisna testi..."
        istisnaFırlat no mesaj 
    with // Desen eşleme
    | :? ArgumentException as ex -> printfn "İstisna tipi ArgumentException : %s" ex.Message
    | :? InvalidOperationException as ex -> printfn "İstisna InvalidOperationException : %s" ex.Message
    | Failure m -> printfn "İstisna tipi Failure : %s" m


// TEST

istisnaYazdır 1 "Deneme 1"
istisnaYazdır 2 "Deneme 2"
istisnaYazdır -1 "Deneme -1"
