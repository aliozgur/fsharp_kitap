(* 09_3_07.fsx *)
let altGörev no= 
    async{
        printfn "Alt görev %d..." no
        do! Async.Sleep(2000) |> Async.Ignore
        printfn "Alt görev %d bitti..." no
    }
let altGörev' no= 
    async{
        printfn "Alt görev %d..." no
        do! Async.Sleep(2000) |> Async.Ignore
        printfn "Alt görev %d bitti..." no
        return no
    }

let anaGörev = 
    async{
        printfn "Ana görev..."
        
        let! c1 = Async.StartChild(altGörev 1)
        let! c2 = Async.StartChild(altGörev 2)
        let! c3 = Async.StartChild(altGörev' 3)

        do! c1
        do! c2
        let! sonuç = c3

        // Sıra ile çalışırlar        
        //do! altGörev 1
        //do! altGörev 2
        //let! sonuç = altGörev 3
        
        // Sonuçları bekleyemeyiz 
        //Async.Start(altGörev 1)
        //Async.Start(altGörev 2)
        
        //let _altGörev' = altGörev' >> Async.Ignore
        //Async.Start(_altGörev' 3)

        printfn "Ana görev bitti... altgörev3 sonucu %d" sonuç       
    }

anaGörev
|> Async.Start