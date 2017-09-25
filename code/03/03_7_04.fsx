(* 03_7_04.fsx *)
#load "03_7_02.2.fs"
#load "03_7_02.3.fs"

// --------- 1. Yöntem TEST---------
open SanalMarket1

let m1 = Müşteri.oluştur "Mahmut" "Tuncer"

printfn "Müşteri %A" m1

// --------- 2. Yöntem TEST---------

open SanalMarket2

let m2 = Müşteri.oluştur "Mahmut" "Tuncer"
printfn "Müşteri %A" m1