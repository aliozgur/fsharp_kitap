(* 02_1_04.fsx *)

#time "on"

printfn "Ana script başladı"
#load "02_1_05.fsx"
printfn "Ana script devam edecek"

#I "libs\\ali"
#load "kare.fsx"

open Kare.Module1

// kare fonksiyonun grafiğini çiz 
printfn "3'ün karesi = %f"  (kare 3.0)

#time "off"
printfn "Performans ve zamanlama ölçümü kapatıldı."
