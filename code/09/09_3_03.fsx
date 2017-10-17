(* 09_3_03.fsx *)
open System
open System.Net

// HATALI KULLANIM !!!
// let! yerine let kullanılıyor
let asyncİndir adres = 
    async{
        use istemci = new WebClient()
        let uri = Uri(adres)
        printfn "Sayfa indiriliyor..."
        let html= istemci.AsyncDownloadString(uri)
        printfn "Sayfa indirildi."
        return html
    }

// DOĞRU KULLANIM
// Önce let! ile asenkron işlemin değeri alınıyor
// Sonra da retrun ile asenkron ifadenin sonucu döndürülüyor
let asyncİndir' adres = 
    async{
        use istemci = new WebClient()
        let uri = Uri(adres)
        printfn "Sayfa indiriliyor..."
        let! html= istemci.AsyncDownloadString(uri)
        printfn "Sayfa indirildi."
        return html
    }

// ALTERNATİF KULLANIM
// let! ve return yerine return! kullanımı
let asyncİndir'' adres = 
    async{
        use istemci = new WebClient()
        let uri = Uri(adres)
        return! istemci.AsyncDownloadString(uri)
    }

// TEST
let sonuç = 
    "http://aliozgur.net" 
    |> asyncİndir''
    |> Async.RunSynchronously


