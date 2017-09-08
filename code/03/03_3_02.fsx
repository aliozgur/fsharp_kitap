(* 03_3_02.fsx *)
let birArttır (loglayıcı: string->unit) x = 
    loglayıcı "İşleme başladım"
    let s = x + 1
    loglayıcı "İşlem tamam"
    s
let ekranaLogla (x:string)  = 
    printfn "Log : %s" x

let dosyayaLogla (x:string) = 
    // Dosyaya loglama kodu
    ()
birArttır ekranaLogla 42
birArttır dosyayaLogla 42