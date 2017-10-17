(* 07_8_01.fsx *)

open System

type Araç(ipucu:string) = 
    member val Sayaç = 0 with get,set
    member this.İpucu = ipucu

    interface IDisposable with
        member this.Dispose() = 
            printfn "Dispose metodu çağırıldı. Kaynakları serbest bırakabiliriz..."

    member this.EkranaYazdır değer = printfn "%A" değer

let birinciYöntemTesti() = 
    let araç =  new Araç("Test")
    araç.İpucu |> ignore
    araç.EkranaYazdır Math.PI
    araç.Sayaç <- 1

    // Üst kontrat tipine dönüştür 
    let disposble = araç :> IDisposable
    // Dispose metodunu çağır
    disposble.Dispose() 
 
birinciYöntemTesti()

let ikinciYöntemTesti() = 
    use araç =  new Araç("Test")
    araç.İpucu |> ignore
    araç.EkranaYazdır Math.PI
    araç.Sayaç <- 1

ikinciYöntemTesti()

