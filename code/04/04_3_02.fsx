(* 04_3_02.fsx *)

type Kişi = {Ad:string;Soyad:string}
type Öğrenci = {KişiselBilgi:Kişi;Numara:int}

type Kullanıcı = 
    | Akademik of Öğrenci
    | İdari of Kişi

// TEST
let akademikKullanıcı = Akademik {KişiselBilgi = { Ad="Arda";Soyad="Özgür"};Numara=1001}
let idariKullanıcı = İdari { Ad="Mahmut";Soyad="Tuncer"}
