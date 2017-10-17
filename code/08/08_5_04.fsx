(* 08_5_04.fsx *)

let ekle x y = x + y
let çarp x y = x * y

let kare x = x * x


let birArttır = ekle 1 
let ikiİleÇarp = çarp 2

let üçEkleVeİkiİleÇarp = ekle 3 >> çarp 2

let birEkleVeİkiİleÇarpVeKaresiniAl = birArttır >> çarp 2 >> kare


// TEST

birArttır 42
ikiİleÇarp 42
üçEkleVeİkiİleÇarp 42
birEkleVeİkiİleÇarpVeKaresiniAl 3



