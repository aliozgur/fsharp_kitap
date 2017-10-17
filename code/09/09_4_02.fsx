(* 09_4_02.fsx *)


let dizi = Array.init 100 (id) 

dizi |> Array.Parallel.iter (fun v -> printfn "Değer %d" v)
dizi |> Array.Parallel.map (fun v -> v*10)
dizi |> Array.Parallel.iteri (fun i v -> printfn "Eleman %i değer %d" i v)
dizi |> Array.Parallel.choose ( fun v -> if v > 50 then Some(i) else None)

