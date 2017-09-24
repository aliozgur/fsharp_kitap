(* 03_5_03.fsx *)

let liste1 = [1;2;3]



let liste2 = [
    1
    2
    3]

// elemanları int tipinden olan liste
let liste1' : int list = [1;2;3] 

// elemanları string tipinden olan liste
let liste2': string list= [
    "1"
    "2"
    "3"]
let boşListe = []



// Elemanları 1 ile 10 arasındaki sayılar olan liste
let liste3 = [1..10]

// Elemanları 1 ile 20 arasında olan
// 1'den itibaren 2'şer artan sayılar
// olan liste
let liste4 = [1..2..20]

// Elemanları 1 ile 20 arasında olan
// 1'den itibaren 0.5'er artan sayılar
// olan liste
let liste5 = [1.0..0.5..20.0]

// Elemanları 100 ile 0 arasında 
//2'şer azalan sayılar olan liste
let liste6 = [100..-2..0]

// Boş liste
let liste7 = []

// 1,2,3,4 ekleniyor
let liste8 = 1::2::3::4::[]


// Elemanları 1,2,3 olan liste
let liste9 = [1;2;3]

// Listenin başına -1 ve 0 eklenir
let liste10 = -1::0::liste7


let liste11 = [1..10]
let liste12 = [-10..0]

let liste13 = liste12@liste11


