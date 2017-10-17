(* 09_5_01.fsx *)

open System.Threading

let ekranaYazdır mesaj = 
    printfn "%s" mesaj
    Thread.Sleep(1000)

let ajan = MailboxProcessor.Start(fun kuyruk -> 
    let rec mesajDöngüsü öncekiMetin = 
        async{
            let! msg = kuyruk.Receive()

            if msg = "|" then
                ekranaYazdır (öncekiMetin)
                return! mesajDöngüsü ""
            else
                return! mesajDöngüsü (öncekiMetin + " " + msg)

        }
    mesajDöngüsü ""
)


[|
    "MailboxProcessor'dan"
    "Merhaba"
    "Dünya!"
    "|"
    "Bugün"
    "mesajlaşma"
    "öğreniyorum."
    "|"
|]
|> Array.map ajan.Post

