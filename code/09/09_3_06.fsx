(* 09_3_06.fsx *)
open System
open System.Net

let asyncİndir adres = 
    async{
        printfn "Başla..."
        do! Async.Sleep(3000)
        use istemci = new WebClient()
        let uri = Uri(adres)
        let! html = istemci.AsyncDownloadString(uri)
        printfn "Bitti."
        return html
    }


let task =  
    "https://www.turkiye.gov.tr"
    |> asyncİndir
    |> Async.StartAsTask 

task.Wait();
printfn "İşlem tamamlandı"