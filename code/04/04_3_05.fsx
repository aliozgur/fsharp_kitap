(* 04_3_05.fsx *)
type Kişi = {Ad:string;Soyad:string}
type Kullanıcı = 
    | Öğrenci of Kişi * int
    | Personel of Kişi

let tanımla (kullanıcı:Kullanıcı) = 
    match kullanıcı with
    | Öğrenci ({Ad=ad;Soyad=soyad},numara) -> 
        printfn "Öğrenci %s %s (%d)" ad soyad numara
    | Personel {Ad=ad;Soyad=soyad} as k -> 
        printfn "Personel %s %s" ad soyad

let öğrenci = Öğrenci ({Ad="Arda";Soyad="Özgür"},1001)
let personel = Personel {Ad="Ali";Soyad="Özgür"}

// TEST
tanımla öğrenci
tanımla personel
