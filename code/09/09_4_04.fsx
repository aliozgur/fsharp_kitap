(* 09_4_04.fsx *)

open System
open System.Threading
open System.Threading.Tasks


let işlemYap no = 
    let mutable sonuç = ""
    for i in 1..10 do
        Thread.Sleep(200)
        sonuç <- sonuç + string(i) + ", "
        printfn "İşlem %d, değer %d" no i
    sonuç


let işlemBaşlat i = 
    Task.Factory.StartNew(fun() -> işlemYap i) :> Task

// Tüm arka plan işlemleri bitene kadar bekle
let tasks = 
    [|1;2;3|]
    |> Array.map işlemBaşlat

Task.WaitAll(tasks)


// En az bir arka plan işlemi bitene kadar bekle
let tasks' = 
    [|1;2;3|]
    |> Array.map işlemBaşlat

Task.WaitAny(tasks')
printfn "En az bir görev bitti"