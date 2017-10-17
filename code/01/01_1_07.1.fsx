(* 01_1_07.1.fsx *)
(* 
    async ifade ile değerleri eş zamanlı olarak terminale yazdırma 
*)
open System
open System.Net
open Microsoft.FSharp.Control.CommonExtensions   

// Değeri ekrana yazdıran asenkron ifade
let ekranaYazdır değer =        
    async {                             
        printfn "Değer %d" değer 
        }

// Yazdırılacak değerler
let sites = [0..10]

sites 
|> List.map ekranaYazdır   // Eş zamanlı görevleri oluştur
|> Async.Parallel          // Görevleri paralel hale getir
|> Async.RunSynchronously  // Görevleri     