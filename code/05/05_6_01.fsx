(* 05_6_01.fsx *)

let d1 = Map.empty.Add("Bir",1).Add("İki",2).Add("Üç",3)

// Map modülü add fonksiyonu
let d1' = Map.add "Dört" 4 d1

// Map<'a,'b> tipi Add üye fonksiyonu
let d1'' = d1.Add("Dört",4)

// Map modülü remove fonksiyonu
let dr1 = Map.remove "Dört" d1'

// Map<'a,'b> tipi Remove üye fonksiyonu
let dr1' = d1'.Remove("Dört")


let d2 = ["Bir",1; "İki",2; "Üç",3] |> Map.ofList
let d3 = [|"Bir",1; "İki",2; "Üç",3|] |> Map.ofArray
let d4 = seq{
            for i in 1..3 do
            yield 
                match i with
                | 1 -> "Bir",1
                | 2 -> "İki",2
                | 3 -> "Üç",3
                | _ -> "",-1} 
                |> Map.ofSeq
