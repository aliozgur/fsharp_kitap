(* 09_5_02.fsx *)

open System.Threading

let mutable toplam = 0

let ajan = MailboxProcessor.Start(fun kuyruk -> 
    let rec mesajDöngüsü() = 
        async{
            let! msg = kuyruk.Receive()
            toplam <- toplam + msg 
            return! mesajDöngüsü()    
        }
    mesajDöngüsü()
)


let mesajGönder i = 
    async{
        return ajan.Post i
    }

toplam <- 0
[|1..100|]
|> Array.map mesajGönder
|> Async.Parallel
|> Async.RunSynchronously

printfn "Toplam: %d" toplam