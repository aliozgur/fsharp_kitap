(* 09_4_06.fsx *)

open System
open System.Threading.Tasks

let istisnaFırlat tip = 
    let sonuç = 
        match tip with
        | 1 -> invalidArg "tip" "Geçersiz argüman"
        | 2 -> invalidOp "Geçersiz işlem"
        | 3 -> failwith "Genel hata"
        | _ -> string(tip)

    sonuç


// Tek bir arka plan işlemi
try
    let t = Task.Factory.StartNew( fun() -> istisnaFırlat 1)
    t.Wait()
with
| :? ArgumentException as aex -> printfn "Arg Hata : %s" aex.Message
| :? AggregateException as aex ->  printfn "Hata : %A" aex.InnerException
| _ as ex -> printfn "Diğer Hata %s" ex.Message


// Birden fazla arka plan işlemi
try
     
    let tasks = 
        [|1;2;3|] 
        |> Array.map ( fun i -> Task.Factory.StartNew( fun() -> istisnaFırlat i) :> Task)

    Task.WaitAll(tasks)
with
| :? ArgumentException as aex -> printfn "Arg Hata : %s" aex.Message
| :? AggregateException as aex ->  printfn "Hata : %A" aex.InnerExceptions
| _ as ex -> printfn "Diğer Hata %s" ex.Message