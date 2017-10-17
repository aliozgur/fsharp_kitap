(* 05_5_01.fsx *)

// Küme oluşturma 
let k1 = set[1;2;3]
let k2 = Set.empty.Add(1).Add(2).Add(3)

// Set modülü add fonksiyonu
let k1' = Set.add 4 k2

// Set tipi Add üye fonksiyonu
let k1'' = k1'.Add 5

// Set modülü remove fonksiyonu
let k2' = Set.remove 3 k2

// Set tipi Remove üye fonksiyonu
let k2'' = k2.Remove 3


// Küme'de aynı değer iki defa olamaz
let k3 = set[1;2;3;3;2;2]
//val k3 : Set<int> = set [1; 2; 3]

//Değer kavrama ile küme oluşturma
let k4 = set[
    for i in 1..10 do
        yield i
]

let k4' = set[
    for i in 1..10 do
        yield! [1..i]

]



// Listeden küme oluşturma
let liste = [1;2;2;3;4;5]
let k5 = Set.ofList liste

// Diziden küme oluşturma
let dizi = [|1;2;2;3;4;5|]
let k6 = Set.ofArray dizi

// Sekanstan küme oluşturma
let sekans = seq{1..5}
let k7 = Set.ofSeq sekans

