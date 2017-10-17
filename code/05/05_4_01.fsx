(* 05_4_01.fsx *)

// yield vs yield! 
let liste = [

    for i in 1..3 do
        yield [1..i]
]
// liste elemanları şöyledir
// [[1]; [1; 2]; [1; 2; 3]]

let liste' = [

    for i in 1..3 do
        yield! [1..i]
]
// liste' elemanları şöyledir
// [1; 1; 2; 1; 2; 3]


// Öz yinelemeli çağırılarda yield! kullanımı
open System.IO
let rec dosyaVeKlasörlerSekansı kök = 
    seq{
        yield! Directory.GetFiles(kök)
        for dir in Directory.GetDirectories(kök) do
            yield! dosyaVeKlasörleriListele dir            
    }

let rec dosyaVeKlasörlerListesi kök = 
    [
        yield! Directory.GetFiles(kök)
        for dir in Directory.GetDirectories(kök) do
            yield! dosyaVeKlasörlerListesi dir            
    ]

let rec dosyaVeKlasörlerDizisi kök = 
    [
        yield! Directory.GetFiles(kök)
        for dir in Directory.GetDirectories(kök) do
            yield! dosyaVeKlasörlerDizisi dir            
    ]

dosyaVeKlasörlerSekansı @"."
dosyaVeKlasörlerListesi @"."
dosyaVeKlasörlerDizisi @"."