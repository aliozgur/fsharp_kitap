(* 01_1_09.1.fsx *)
// MailboxProcessor 
// Ajanı oluştur
let ajan = MailboxProcessor.Start(fun kuyruk -> 
    let rec mesajDöngüsü() =
        async{
            let! msg = kuyruk.Receive()
            printfn "Gelen Mesaj: %s" msg
            do! mesajDöngüsü() 
            }
    mesajDöngüsü()
)

// Ajana mesaj gönder
ajan.Post "F# ile Fonksiyonel Programlama"