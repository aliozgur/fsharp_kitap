(* 03_3_03.fsx *)

// Prosedürel yaklaşım
let map  (f:'a->'b) (liste : 'a list) : 'b list =    
    let sonuç = seq{for x in liste -> (f x)}
    sonuç |> List.ofSeq

[1..10] |> map (fun x -> x * x)

// Öz yinelemeli fonksiyon kullanımı ile daha fonksiyonel bir yaklaşım
let rec map' (f:'a->'b) (liste : 'a list) : 'b list =
    match liste with
    | [] -> []
    | baş::geriKalanlar -> (f baş) :: (map' f geriKalanlar)

[1..10] |> map' (fun x -> x * x)
