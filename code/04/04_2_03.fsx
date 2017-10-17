(* 04_2_03.fsx *)

type Kişi = {Ad:string;Soyad:string;DoğumYılı:int}

type Öğrenci = {
    KişiselBilgiler: Kişi
    Numara: int
}

let kişiBilgisiGöster (kişi: Kişi) = 
    printfn "%s %s" kişi.Ad kişi.Soyad

let kişiBilgisiGöster' {Ad=a;Soyad=s;} = 
    printfn "%s %s" a s
    
let arda = {Ad="Arda";Soyad="Özgür";DoğumYılı=2008}

let {Ad=a;Soyad=s} = arda
let {Ad=_;Soyad=_;DoğumYılı=d} = arda

// TEST

kişiBilgisiGöster' arda

printf "%s %s" a s
printf "%d" d

printf "%s %s" arda.Ad arda.Soyad
printf "%d" arda.DoğumYılı


