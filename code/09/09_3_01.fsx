(* 09_3_01.fsx *)
open System
open System.Net
let indir adres = 
    use istemci = new WebClient()
    let uri = Uri(adres)
    istemci.DownloadString(uri)
    
"http://aliozgur.net" |> indir

