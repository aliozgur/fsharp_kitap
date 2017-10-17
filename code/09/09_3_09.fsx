(* 09_3_09.fsx *)

let rnd = System.Random(int System.DateTime.Now.Ticks)
let asenkronMerhaba ad = 
    async{
        if ad = "" then
            failwith "Ad boş olamaz"

        printfn "Merhaba, %s" ad
        do! Async.Sleep 1000 
        return rnd.Next()
    }

let asenkronİşlemler = 
    let liste = ["Arda";"Ali";"Sarp"]
    liste
    |> List.map asenkronMerhaba
// val asenkronİşlemler : Async<int> list

let paralelİşlemler = 
    asenkronİşlemler
    |> Async.Parallel
// val paralelİşlemler : Async<int[]>


paralelİşlemler
|> Async.RunSynchronously