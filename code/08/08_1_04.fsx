(* 08_1_04.fsx *)
open System

let (|HarfVarMı|) harf girdi = 

    let harfler = 
        (girdi :> char seq)
        |> Set.ofSeq
        |> Set.map ( fun c  -> Char.ToLowerInvariant(c))

    harfler
    |> Set.exists( fun c -> c = Char.ToLowerInvariant(harf))
  

let HarfKontrolü harf metin = 
    match metin with
    | HarfVarMı harf true -> printfn "Harf var => %c" harf
    | _ -> printfn "Harf yok => %c" harf

// TEST

"Mahmut Tuncer" |> HarfKontrolü 'm'
"Mahmut Tuncer" |> HarfKontrolü 'Z'

