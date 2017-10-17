(* 09_5_03.fsx *)

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


ajan.PostAndReply( fun cevapKanalı -> KarekökHesaplaVeCevapDön(44.0,cevapKanalı))
ajan.PostAndReply( fun cevapKanalı -> KarekökHesaplaVeCevapDön(16.0,cevapKanalı))
ajan.PostAndReply( fun cevapKanalı -> KarekökHesaplaVeCevapDön(256.0,cevapKanalı))

ajan.PostAndReply( fun cevapKanalı -> EchoMesajı("Nasılsın?",cevapKanalı))
ajan.PostAndReply( fun cevapKanalı -> MerhabaMesajı(cevapKanalı))


ajan.Post(KarekökHesaplaVeYazdır 16.0)