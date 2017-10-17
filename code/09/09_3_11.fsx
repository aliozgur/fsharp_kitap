(* 09_3_11.fsx *)

open System
open System.Threading

let onaKadarSay no = 
    async{
        for i in 1..10 do
            printfn "%d değer %d" no i
            do! Async.Sleep(1000)
    }

(*
Async.TryCancelled(onaKadarSay,( fun _ -> printfn "İşlem iptal edildi"))
|> Async.Start
*)

// Yöntem - 1 : CancelDefaultToken
onaKadarSay 1 |> Async.Start
onaKadarSay 2 |> Async.Start
onaKadarSay 3 |> Async.Start


Thread.Sleep(3000)
Async.CancelDefaultToken()

// Yöntem -2 : CancellationTokenSource 
let iptalKaynağı = new CancellationTokenSource()

Async.Start (onaKadarSay 1)
Async.Start (onaKadarSay 2, iptalKaynağı.Token)
Async.Start (onaKadarSay 3)


Thread.Sleep(3000)
iptalKaynağı.Cancel()


// Yöntem-1 : İptal işleminden haberdar olma

let iptalKaynağı' = new CancellationTokenSource()
Async.StartWithContinuations(
    onaKadarSay 1,
    ( fun _ -> ()), // Başarı uzantısı
    ( fun _ -> ()), // İstisna uzantısı
    ( fun (ex:OperationCanceledException) -> (printfn "İşlem iptal edildi")),
    iptalKaynağı'.Token
    )

iptalKaynağı'.CancelAfter(3000)

// Yöntem-2 : İptal işleminden haberdar olma
let iptalKaynağı'' = new CancellationTokenSource()
let iptalUzantısı (ex:OperationCanceledException) = 
    printfn "İşlem iptal edildi"

let arkaPlanİşlemi = Async.TryCancelled(onaKadarSay 1,iptalUzantısı)
Async.Start(arkaPlanİşlemi, iptalKaynağı''.Token)

iptalKaynağı''.CancelAfter(3000)