(* 06_2_02.fsx *)

let dizi1 = [|1;2;3|]
let dizi2 = dizi1

dizi2.[0] <- -1

printfn "dizi1 = %A" dizi1
// Çıktı : dizi1 = [|-1; 2; 3|]

printfn "dizi2 = %A" dizi2
// Çıktı : dizi2 = [|-1; 2; 3|]
