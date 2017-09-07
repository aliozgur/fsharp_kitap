(* 01_1_07.fsx *)
(* 
    async kullanarak eş zamanlı olarak web sitesi sayfa indirme 
*)
open System
open System.Net
open Microsoft.FSharp.Control.CommonExtensions   

// Web sayfasını indiren fonksiyon
let indir adres =        
    async {                             
        let req = WebRequest.Create(Uri(adres)) 
        use! resp = req.AsyncGetResponse() 
        use stream = resp.GetResponseStream() 
        use reader = new IO.StreamReader(stream) 
        let html = reader.ReadToEnd() 
        printfn "İndirme tamamlandı %s" adres 
        }

// İndirilecek web sayfaları listesi
let sites = ["http://aliozgur.net";
             "http://fsharp.org"]

sites 
|> List.map indir  // Eş zamanlı görev listesi oluştur
|> Async.Parallel          // Eş zamanlı görevleri paralel çalışacak şekilde ayarla
|> Async.RunSynchronously  // Görevleri başlat
