(* 09_2_05.fsx *)

open System
open System.Collections.Generic
open System.Threading
open System.Threading.Tasks

let finished = new CountdownEvent(1)

let işlemYap() = 
    for i in 1..5 do
        Thread.Sleep(500)
        let t = Thread.CurrentThread
        printfn "ThreadId : %d, değer %d" t.ManagedThreadId i
    
    finished.Signal() |> ignore

for i in [1..3] do
    finished.AddCount()    
    let t = Thread(işlemYap)
    t.Start()

finished.Signal()
finished.Wait()

printfn "İşlemler bitti"


