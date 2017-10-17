(* 07_8_02.fsx *)
open System
type VeritabanıBağlantısı(connStr:string) = 
    let mutable _isDisposed = false
    let mutable _bağlantıAçık = false
    let _connStr = connStr
    
    interface IDisposable with
        member this.Dispose() = 
            if not _isDisposed then
                this.BağlantıyıKapat()   
                _isDisposed <- true
    member this.BağlantıyıAç() = 
        if _isDisposed then
            failwith "Bağlantı nesnesi geçerli değil!"
        
        if not _bağlantıAçık then            
            _bağlantıAçık <- true
            printfn "Bağlantı açıldı."
        else
            printfn "Bağlantı zaten açık!"        

    member this.BağlantıyıKapat() = 
        if _isDisposed then
            failwith "Bağlantı nesnesi geçerli değil!"

        if _bağlantıAçık then            
            _bağlantıAçık <- false
            printfn "Bağlantı kapatıldı."
        else
            printfn "Bağlantı zaten kapalı."
        
    member this.Çalıştır (sqlCümlesi:string) = 
        if _isDisposed then
            failwith "Bağlantı nesnesi geçerli değil!"
        if not _bağlantıAçık then            
            failwith "Bağlantı aktif değil!"        
        
        printfn "Çalıştır : %s" sqlCümlesi
        ()

let bağlantıKur connStr = 
    use c = new VeritabanıBağlantısı(connStr)
    c.BağlantıyıAç()
    c

// TEST
let bağlantı = bağlantıKur "..."
bağlantı.Çalıştır "select * from XYZ"


let bağlantıKur' connStr = 
    let c = new VeritabanıBağlantısı(connStr)
    c.BağlantıyıAç()
    c

let çalıştır sql = 
    use bağlantı' = bağlantıKur' "..."
    bağlantı'.Çalıştır sql

çalıştır "select * from xyz"

// Ekran çıktısı:
// Bağlantı açıldı.
// Çalıştır : select * from xyz
// Bağlantı kapatıldı.

let çalıştır' connStr  callback = 
    use c = new VeritabanıBağlantısı(connStr)
    c.BağlantıyıAç()
    callback c

çalıştır' "..." (fun c -> c.Çalıştır "select * from xyz")
// Ekran çıktısı:
// Bağlantı açıldı.
// Çalıştır : select * from xyz
// Bağlantı kapatıldı.

using (bağlantıKur' "...") (fun c -> c.Çalıştır "select * from xyz")
// Ekran çıktısı:
// Bağlantı açıldı.
// Çalıştır : select * from xyz
// Bağlantı kapatıldı.
 
