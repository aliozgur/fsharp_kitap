(* \code\02\vscode_ornek\Merhaba\Program.fs *)

open System
open Utils

[<EntryPoint>]
let main argv =
    printfn "F# ile merhaba dünya"
    printfn "3'ün karesi %d" (Matematik.kare 3)
    printfn "3'ün küpü  %d" (Matematik.küp 3)
    
    0 // çıkış kodu