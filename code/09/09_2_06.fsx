(* 09_2_06.fsx *)

open System.Threading

let _işlemYap limit = 
    for i in 1..limit do
        Thread.Sleep(500)
        let t = Thread.CurrentThread
        printfn "ThreadId : %d, değer %d" t.ManagedThreadId i

let işlemYap() = 
   _işlemYap 5

let işlemYap' (limit:obj) = 
   _işlemYap (limit :?> int)

// İsimsiz fonksiyon ile parametresiz işlemi kuyruğa koy
ThreadPool.QueueUserWorkItem(fun _ -> işlemYap())

// Parametre gerektiren işlemi kuyruğa koy
ThreadPool.QueueUserWorkItem(WaitCallback işlemYap', box 5 )


let işlemYap'' (limit:obj) (timout:bool) = 
   _işlemYap (limit :?> int)

// Therad havuzunda sinyallerin kullanımı
use sinyal = new ManualResetEvent(false)
let reg = ThreadPool.RegisterWaitForSingleObject(sinyal,WaitOrTimerCallback işlemYap'',box 5,-1,true)

Thread.Sleep(500)
printfn "Sinyal gönderilecek"
sinyal.Set()
Thread.Sleep(500)
reg.Unregister(sinyal)

