(* 08_5_01.fsx *)

// İlk versiyon
let toplaVeLogla = 
    let toplam = 
        [1..10] 
        |> List.fold ( fun acc değer -> acc + değer) 0
        
    printfn "Toplam = %d" toplam
    toplam


// Parametrize edilmiş versiyon
let toplaVeLogla' logger liste = 
    // 0
    let ilkDeğer = 0
    
    // fun acc değer -> acc + değer
    let toplayıcı bakiye değer = bakiye  + değer
    
    let toplam = 
        liste // [1..10]
        |> List.fold toplayıcı ilkDeğer

    //printfn "Toplam = %d" toplam
    logger toplam
    toplam

// TEST
let sonuç =
    [1..10] 
    |> toplaVeLogla' (fun t -> printfn "Toplam = %d" t)
