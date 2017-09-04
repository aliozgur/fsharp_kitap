(* 01_06.fsx *)
let mutable a = 42
printfn "a = %d" a

a <- 43 // Değer ifadesinin değerini değiştir
printfn "a = %d" a


let mutable b = "F# ile Fonksiyonel Programlama"
printfn "b = %s" b

b <- "F# ile fonksiyonel programlama" // Değer ifadesinin değerini değiştir
printfn "b = %s" b

let mutable pi = 3.14
printfn "pi = %f" pi
pi <- 3.0 // Değer ifadesinin değerini değiştir
printfn "pi = %f" pi

