(* 09_4_03.fsx *)

open System
open System.Threading
open System.Threading.Tasks

let işlemYap no = 
    for i in 1..10 do
        Thread.Sleep(200)
        printfn "İşlem %d, değer %d" no i

let t = Task.Factory.StartNew(fun() -> işlemYap 1)
t.Wait()


let işlemYap' no = 
    let mutable sonuç = ""
    for i in 1..10 do
        Thread.Sleep(200)
        sonuç <- sonuç + string(i) + ", "
        printfn "İşlem %d, değer %d" no i
    sonuç

let t' = Task.Factory.StartNew(fun() -> işlemYap' 1)
let sonuç = t'.Result // Bitene kadar bekle
printfn "Sonuç %s" sonuç
