(* 03_5_01.fsx *)

// Değeri unit tipinden olan basit bir değer ifadesi
let değer = ()

// unit döndüren bir fonksiyon
let fonksiyon1 x = 
    printfn "x'in değeri = %d" x
    ()

// Dolaylı olarak unit döndüren fonksiyon
// Son çağrı printfn ve printfn dönüş değeri unit
let fonksiyon1' x = 
    printfn "x'in değeri = %d" x


// Parametresiz fonksiyon
// Aslında bu fonkisyon tipi unit olan tek parametreli 
// bir fonksiyon
let fonksiyon2 () =
    printfn "Parametresiz fonksiyon"
    42

// Parametre değerlerini toplayan ancak 
// sonucu yutan  ve dönüş değeri olmayan bir fonksiyon
let fonksiyon3 x y =
    x + y |> ignore // toplama sonucu yutuldu
    printfn "Toplama yapıldı ancak sonuç yutuldu"
    ()
 
// Son parametresi unit tipinde olan fonksiyion
let fonksiyon4 x y z:unit = 
    x + y |> ignore // toplama sonucu yutuldu
    printfn "Toplama yapıldı ancak sonuç yutuldu"
    ()

// TEST
fonksiyon1 42
fonksiyon1' 42

fonksiyon2()
fonksiyon3 42 0
fonksiyon4 42 0 ()