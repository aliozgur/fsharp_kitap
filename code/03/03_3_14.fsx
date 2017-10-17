(* 03_3_14.fsx *)

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
let şuAn() = System.DateTime.Now
let üçSaniyeBittiMi x = 
    şuAn() - x <= System.TimeSpan.FromSeconds(3.0) 
let  başlangıçZamanı  = şuAn()
koşulluDöngü 
    ( fun() -> üçSaniyeBittiMi başlangıçZamanı ) 
    ( fun() -> 
        printfn "Koşullu döngü, başlangıç = %A, şu an = %A" başlangıçZamanı System.DateTime.Now
    )