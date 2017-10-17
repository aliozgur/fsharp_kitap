(* 04_1_03.fsx *)

// match..with ile normal desen eşleme
let karşılaştır x y = 
    match (x,y) with
    | a,b when a > b -> printfn "%d > %d" a b
    | a,b when a < b -> printfn "%d < %d" a b
    | _ -> printfn "%d = %d" x y

// function ile desen eşleme
let karşılaştır' = 
    function
    | a,b when a > b -> printfn "%d > %d" a b
    | a,b when a < b -> printfn "%d < %d" a b
    | a,b -> printfn "%d = %d" a b

// TEST
karşılaştır' (1,2)
karşılaştır' (2,1)
karşılaştır' (1,1)

// List.map ilk parametre olarak fonksiyon alır.
// List.map fonksiyonuna ilk parametre olarak function
// ile oluşturulmuş desen eşleme ifadesi geçiyoruz  
[1..10] |> List.map (function 
                            | a when a <= 5 -> a * 10
                            | a -> -1 )
