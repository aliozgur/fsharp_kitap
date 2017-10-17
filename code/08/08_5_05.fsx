(* 08_5_05.fsx *)

let çarp x y = x * y

// 1) Tek parametreli fonksiyon
let merhaba ad = printfn "Merhaba,%s!" ad
let merhaba' = printfn "Merhaba,%s!"

["Ali";"Arda"] |> List.iter merhaba
["Ali";"Arda"] |> List.iter merhaba'

// 2) Çok parametreli fonksiyonu kısmi uygulama 
// ile tek parametreli hale getiriyoruz
let ikiİleÇarp = çarp 2
[1..10] |> List.map ikiİleÇarp
