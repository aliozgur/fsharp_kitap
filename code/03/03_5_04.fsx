(* 03_5_04.fsx *)

let sayı = 2.0

let liste = [
    yield sayı // sayının kendisi
    yield sayı ** 2.0 // sayının karesi
    yield sayı ** 3.0  // sayının küpü
]


// Listedeki sayıların karesini liste olarak
// olarak döndüren fonksiyon.
// Listenin ilk yarısında çift sayıların karesi,
// ikinci kısmında da tek sayıların karesi yer alır
let kareleriAl x = 
    [
        // yerel kare fonksiyonu
        let kare m = m * m
        
        // Çift sayıların karesi
        for i in x do
          if i % 2 = 0 then
            yield kare i
        
        // Tek sayıların laresi
        for i in x do
         if i % 2 = 1 then
            yield kare i
    ]

kareleriAl [1..10]

