(* 09_3_02.fsx *)
open System
open System.Net

let asyncİndir adres = 
    async{
        use istemci = new WebClient()
        let uri = Uri(adres)
        let! html = istemci.AsyncDownloadString(uri)
        return html
    }

"https://www.turkiye.gov.tr"
|> asyncİndir
|> Async.RunSynchronously
|> printfn "%s" 

printfn "İndirme tamamlandı"


