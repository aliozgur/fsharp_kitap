(* 01_1_09.fsx *)
(*
    MailboxProcessor modülü ile kuyruk örneği
*)

// Kuyruğu oluştur
let kuyruk = MailboxProcessor.Start(fun inbox-> 

    // Kuyruktaki mesajları işleyecek olan fonksiyon tanımı
    let rec mesajİşleyiciDöngüsü() = async{
        
        // Kuyruktan mesajı oku, mesaj yoksa bekle
        let! msg = inbox.Receive()
        
        // Mesajı işle
        printfn "Gelen mesaj: %s" msg

        // mesajİşleyiciDöngüsü fonksiyonu öz yinelemeli olduğu için başa dön
        return! mesajİşleyiciDöngüsü()  
        }

    // Mesaj işleme döngüsünü başlat 
    mesajİşleyiciDöngüsü() 
    )

kuyruk.Post "F# ile Fonksiyonel Programlama" 
kuyruk.Post "Yazar:Ali Özgür" 
kuyruk.Post "Yayın Evi : Dikeyeksen" 