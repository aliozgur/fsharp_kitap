(* 06_1_01.fsx *)

let liste1 = [1;2;3]
let liste2 = [4;5;6]

let yeniListe = liste1@liste2
//[1;2;3;4;5;6]

// List.tail fonksiyonu ile bir listenin birinci
// elemanı sonrasındaki elemanlarından oluşan listeyi yani
// kuyruğunu yeni bir liste olarak alabiliriz.
// kombineListe için List.tail üç defa arka arkaya çağırarak 
// son üç elemanının içeren listeyi alıyoruz.
let yeniListeSonÜçEleman = yeniListe 
                                |> List.tail 
                                |> List.tail
                                |>List.tail
// [4;5;6]

System.Object.ReferenceEquals(yeniListeSonÜçEleman,liste2)
// Sonuç true yani liste2 ile yeni listenin son üç 
// elemanından oluşan listenin referansları aynıdır