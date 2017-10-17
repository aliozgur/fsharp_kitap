(* 09_3_08.fsx *)
let asenkronİfade = 
    async{
        printfn "Başla ..."
        do! Async.Sleep(2000) |> Async.Ignore
        printfn "Tamamlandı."
    }

let asenkronİfade' () = 
    async{
        printfn "Başla ..."
        do! Async.Sleep(2000) |> Async.Ignore
        printfn "Tamamlandı."
    }

asenkronİfade
|> Async.Start

asenkronİfade'()
|> Async.Start