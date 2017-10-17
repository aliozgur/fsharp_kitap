(* 09_2_03.fsx *)

open System.Threading
use sinyal = new ManualResetEvent(false)

let işlemYap() = 
    for i in [1..10] do
        
        // Sinyal bekle
        if i = 1 then
            sinyal.WaitOne() |> ignore
        printfn "%A İşlem yap, değer %d" System.DateTime.Now i
        if i % 2 = 0 then
            sinyal.Reset() |> ignore
            sinyal.WaitOne() |> ignore

let t = Thread(işlemYap)
t.Start()

for i in 1..10 do
    sinyal.Set() |> ignore
    Thread.Sleep(1000)
