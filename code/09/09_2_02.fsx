
(* 09_2_02.fsx *)

open System.Threading
use sinyal = new AutoResetEvent(false)

let işlemYap() = 
    for i in [1..10] do
        // Sinyal bekle
        sinyal.WaitOne() |> ignore
        printfn "%A İşlem yap, değer %d" System.DateTime.Now i


let t = Thread(işlemYap)
t.Start()

for i in 1..10 do
    sinyal.Set() |> ignore
    Thread.Sleep(1000)
