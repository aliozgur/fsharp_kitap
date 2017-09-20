(* 03_3_144.fsx *)

// Öz yinelemeli döngü fonksiyonu
let rec döngü f sayaç = 
    
    if sayaç = 0 then 
        () // Bitiş koşulu, sayaç sıfır ise unit döndür
    else
        //G irdi olarak verilen fonksiyonunu
        // sayaç değeri ile çağır
        f(sayaç) // f fonksiyonunu sayaç parametresi ile çağır
        döngü f (sayaç-1) // tekrar döngü çağır


// TEST
let sayaç = 5
döngü (fun i-> printfn "Döngü, sayaç = %d" i) sayaç

// Koşullu döngü öz yinelemeli fonksiyonu
let rec koşulluDöngü koşul f = 
    
    if koşul() then // Koşul doğru ise
        
        f() // Önce fonksiyonu çağır
        koşulluDöngü koşul f // Tekrar koşulluDöngü çağır
    else
        () // Koşul doğru değil unit dön ve sonlan

// TEST
let mutable koşul = 10
koşulluDöngü 
    ( fun() -> koşul > 5 ) 
    ( fun() -> 
        printfn "Koşullu döngü, sayaç = %d" koşul
        koşul <- koşul-1
    )