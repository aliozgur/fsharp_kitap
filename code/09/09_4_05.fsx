(* 09_4_05.fsx *)

open System
open System.Threading
open System.Threading.Tasks


let iptalKaynağı = new CancellationTokenSource()

let işlemYap (token:CancellationToken) = 
    let mutable koşul = true
    while koşul do
        Thread.Sleep(1000)
        printfn "Saat %A" System.DateTime.Now

        if token.IsCancellationRequested then
            koşul <- false
   
let t = Task.Factory.StartNew(fun () -> işlemYap iptalKaynağı.Token)

Thread.Sleep(3000)

iptalKaynağı.Cancel()
