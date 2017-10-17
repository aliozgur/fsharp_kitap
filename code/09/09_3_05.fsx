(* 09_3_05.fsx *)
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

let indirmeArkaPlanİşlemi = 
    "https://www.turkiye.gov.tr" 
    |> asyncİndir 

Async.StartWithContinuations(
    indirmeArkaPlanİşlemi,
    ( fun s -> printfn "İndirme tamamlandı"), // İşlem sonucu
    ( fun _ -> ()), // İşlemde hata
    ( fun _ -> ())  // İşlem iptal edildi
)

