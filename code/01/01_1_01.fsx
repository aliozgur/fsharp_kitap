(* 01_1_01.fsx *)

let rec fact x = if x <= 1 then 1 else x * fact (x - 1)
fact 5