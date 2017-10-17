(* 06_5_02.fsx *)

// ---------- Sayaç ile döngü ----------

let mutable sayaç = 10
while sayaç <> 0 do
    printfn "While -> Sayaç = %d" sayaç
    sayaç <- sayaç - 1;


for i=1 to 10 do
    printfn "for to -> Sayaç = %d" i

for i=10 downto 1 do
    printfn "for downto -> Sayaç = %d" i

for i in [1..10] do
    printfn "for in -> Sayaç = %d" i
    
// ---------- Karmaşık koşullar ile döngü ----------
let mutable liste = [1..10]
let mutable listeBoyutu = liste |> List.length
while listeBoyutu <> 0 do
    printfn "while ->  liste.[0]= %d" liste.[0]
    liste <- (liste |> List.tail)
    listeBoyutu <- (liste |> List.length)


liste <- [1..10]
listeBoyutu <- (liste |> List.length)
for i = listeBoyutu downto 1 do
    printfn "for in ->  liste.[0]= %d" liste.[0]
    liste <- liste |> List.tail

// ---------- for in desen eşleme ----------

type Kişi = {Ad:string;Soyad:string}

let kişiListesi = [
    for i in 1..10 do 
        yield {
            Ad = sprintf "Kişi Ad %d" i
            Soyad=sprintf" Kişi Soyad %d" i}
]

for {Ad=ad;Soyad=_} in kişiListesi do
    printfn "Ad -> %s" ad
