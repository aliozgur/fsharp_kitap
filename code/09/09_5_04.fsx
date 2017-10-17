(* 09_5_04.fsx *)

type KarekökHesaplaMesajı = 
    | KarekökHesaplaVeCevapDön of float * AsyncReplyChannel<float>
    | KarekökHesaplaVeYazdır of float
    | EchoMesajı of string * AsyncReplyChannel<string>
    | MerhabaMesajı of AsyncReplyChannel<string>

let ajan = MailboxProcessor<KarekökHesaplaMesajı>.Start(fun kuyruk -> 

    let rec mesajDöngüsü() = 
        async{

            let! msg  = kuyruk.Receive()
            match msg with 
            | KarekökHesaplaVeCevapDön(sayı,kanal) -> kanal.Reply(sqrt sayı) |> ignore
            | KarekökHesaplaVeYazdır sayı -> printfn "Sonuç : %f" (sqrt sayı)
            | EchoMesajı (mesaj,kanal) -> kanal.Reply (sprintf "Echo : %s" mesaj) |> ignore
            | MerhabaMesajı (kanal) -> kanal.Reply("Sana da merhaba!") |> ignore
            return! mesajDöngüsü()
        }
    mesajDöngüsü()
)


let karekökHesapla değer = 
    ajan.PostAndAsyncReply(fun cevapKanalı -> KarekökHesaplaVeCevapDön(değer,cevapKanalı))

let karekökHesapla' değer = 
    async{
        return ajan.PostAndReply(fun cevapKanalı -> KarekökHesaplaVeCevapDön(değer,cevapKanalı))
    }

let echoMesajı metin = 
    ajan.PostAndAsyncReply(fun cevapKanalı -> EchoMesajı(metin,cevapKanalı))


[|16.0;23.0;256.0|]
|> Array.map karekökHesapla
|> Async.Parallel
|> Async.RunSynchronously

[|16.0;23.0;256.0|]
|> Array.map karekökHesapla'
|> Async.Parallel
|> Async.RunSynchronously

