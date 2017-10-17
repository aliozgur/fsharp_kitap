(* 09_2_01.fsx *)

open System.Threading

let birdenBeşeKadarSay() = 
    for i in [1..5] do
        Thread.Sleep(100)
        let threadId = Thread.CurrentThread.ManagedThreadId
        printfn "Thread %d : %d" threadId i
let threadOluştur() = 
    let thread = Thread(birdenBeşeKadarSay)
    thread.Start()

// TEST
threadOluştur()
threadOluştur()
threadOluştur()

printfn "Threadler çalıştırıldı"

let birdenİtibarenSay' (sonDeğer:obj) = 
    let değer = unbox<int> sonDeğer 
    // Alternatif olarak alt tipe dönüşüm operatörü de kullanılabilir 
    // let değer = (sonDeğer :?> int)
    for i in [1..değer] do
        Thread.Sleep(100)
        let threadId = Thread.CurrentThread.ManagedThreadId
        printfn "Thread %d : %d" threadId i

let threadOluştur'() = 
    let thread = Thread(ParameterizedThreadStart birdenİtibarenSay')
    thread.Start(box 5)

// TEST
threadOluştur'()
threadOluştur'()
threadOluştur'()

printfn "Threadler çalıştırıldı"

