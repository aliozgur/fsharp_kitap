(* 04_5_02.fsx *)

let x = lazy(2+2)
let y = Lazy<int>.Create(fun () -> 2 + 2)

let x' = lazy(printfn "Sonradan değerle")

let y' = Lazy<string>.Create( fun() -> sprintf "%d + %d = %d" 2 2 (2+2))


let kare x = x*x
let sonuç = lazy(kare 2)
let sonuç' = Lazy<int>.Create( fun() -> kare 3 )

printfn "Sonuç : kare 2 = %d" sonuç.Value
printfn "Sonuç : kare 3 = %d" (sonuç'.Force())


let küp x =
    let k = x * x * x 
    printfn "%d'nin küpü %d " x k
    k

let üçünKüpü = lazy ( küp 3)

// İlk değerleme
printfn "İfadeyi değerliyoruz. Sonuç %d " (üçünKüpü.Value)

// İkinci defa değerleme
printfn "Tekrar değerliyoruz. Sonuç %d " (üçünKüpü.Force())
