(* 01_2_04.fsx *)
let f(x)  = x + 1 // bir arttırma fonksiyonu tanımı
let g(x) = x * x // kare alma fonksiyonu tanımı

printfn "Sonuç f(g(1)) = %d" (f(g(1))) // Sonuç f(g(1) = 2
printfn "Sonuç g(f(1)) = %d" (g(f(1))) // Sonuç g(f(1) = 4