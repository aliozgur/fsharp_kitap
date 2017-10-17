(* 09_2_04.fsx *)


open System
open System.Collections.Generic
open System.Threading
open System.Threading.Tasks

let sinyaller = new List<WaitHandle>()

let işlemYap() = 
    let evt = new ManualResetEvent(false)
    sinyaller.Add(evt)
    for i in 1..5 do
        Thread.Sleep(500)
        let t = Thread.CurrentThread
        printfn "ThreadId : %d, değer %d" t.ManagedThreadId i
    
    evt.Set() |> ignore

for i in [1..3] do
    let t = Thread(işlemYap)
    t.Start()

Thread.Sleep(100)
WaitHandle.WaitAny(sinyaller.ToArray())

printfn "İşlemler bitti"
