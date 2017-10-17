(* 09_2_12.fsx *)

open System.Threading

let a = ref 0
let b = ref 0


let işlemYap(v:obj) = 
    printfn "Thread 1: a'yi kilitle"
    lock (a) (
                fun () -> 
                    printfn "Thread 1: a kilitli"
                    Thread.Sleep(3000) |> ignore
                    
                    printfn "Thread 1: b'yi kilitle"
                    lock (b) ( 
                                fun () -> 
                                    printfn "Thread 1: b kilitli"
                                    a := !a + (v :?> int)
                                    b := !a + !b + (v :?> int)
                            ) 
            )

let işlemYap'(v:obj) = 
    printfn "Thread 2: b'yi kilitle"
    lock (b) (
                fun () -> 
                    printfn "Thread 2: b kilitli"
                    Thread.Sleep(3000) |> ignore
                    
                    printfn "Thread 2: a'yi kilitle"
                    lock (a) ( 
                                fun () -> 
                                    printfn "Thread 2: a kilitli"
                                    a := !a + (v :?> int)
                                    b := !a + !b + (v :?> int)
                            ) 
            )

ThreadPool.QueueUserWorkItem(WaitCallback işlemYap,5)
Thread.Sleep(1000)
ThreadPool.QueueUserWorkItem(WaitCallback işlemYap',5)

()