(* 06_7_02.fsx *)

let böl bölen bölünen = 
    if bölen = 0 then
        failwith "Bölen 0 olamaz"

    bölünen / bölen

12 |> böl 2

12 |> böl 0
// Fırlatılan istisna bilgisi
// System.Exception: Bölen 0 olamaz


let böl' bölen bölünen = 
    if bölen = 0 then
        failwithf "Bölen %d olamaz. Fonksiyon adı %s " 0 "böl'"

    bölünen / bölen

12 |> böl' 0
// Fırlatılan istisna bilgisi
// System.Exception: Bölen 0 olamaz. Fonksiyon adı böl'
