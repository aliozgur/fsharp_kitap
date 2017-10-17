(* 09_3_10.fsx *)

open System
let istisnaFırlat tip = 
    async{
        let sonuç = 
            match tip with
            | 1 -> invalidArg "tip" "Geçersiz argüman"
            | 2 -> invalidOp "Geçersiz işlem"
            | 3 -> failwith "Genel hata"
            | _ -> string(tip)

        return sonuç
    }

let asenkronİşlem no = 
    async{
        try
            let! sonuç = istisnaFırlat no
            return sonuç
        with
        | :? ArgumentException as ae -> return ae.Message
        | :? InvalidOperationException as iop -> return iop.Message
        | _ as ex -> return ex.Message
    }


let sonuç = Async.RunSynchronously(asenkronİşlem 3)
printfn "Sonuç: %s" sonuç


let asenkronİşlem' no = 
    async{
            let! sonuç = istisnaFırlat no
            return sonuç
    }

Async.StartWithContinuations(
    asenkronİşlem' 2
    ,(fun sonuç -> printfn "Sonuç :%s" sonuç) // Başarılı işlem uzantı fonk
    ,(fun ex -> printfn "İstisna oluştu: %s" ex.Message) // İstisna uzantı fonk
    ,(fun _ -> printfn "İşlem iptal edildi") // İptal uzantı fonk
)


let sonuç' = 
    asenkronİşlem' 2
    |> Async.Catch
    |> Async.RunSynchronously

match sonuç' with
| Choice1Of2 s -> printfn "Sonuç :%s" s
| Choice2Of2 (ex:exn) -> printfn "Hata: %s" ex.Message