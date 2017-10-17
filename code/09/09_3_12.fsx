(* 09_3_12.fsx *)


let onaKadarSay = 
    async{
        for i in 1..10 do 
            printfn "Değer : %d" i
            do! Async.Sleep(1000)
    }

let t = Async.StartAsTask onaKadarSay
t.Wait()