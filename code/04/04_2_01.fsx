(* 04_2_01.fsx *)


type Kişi = {Ad:string;Soyad:string;DoğumYılı:int option}

type Öğrenci = {
    KişiselBilgiler: Kişi
    Numara: int
}

type Fakülte = {
    Id:int
    Ad: string
    Dekan: Kişi
}

type Bölüm = {
    Id:int
    Ad: string
    Kısaltma : int * string
    Fakültesi: Fakülte
    BölümBaşkanı: Kişi
    Sekreter: Kişi
    KayıtOluşturmaTarihi: System.DateTime
}


let arda = {Ad="Arda";Soyad="Kişi";DoğumYılı=Some(2008)}
let öğrenci = {KişiselBilgiler=arda;Numara=11711001}

let bölüm = {
        Id=1
        Ad="Ekonomi"
        Kısaltma=(1,"EC")
        Fakültesi = {
                        Id=1
                        Ad="İşletme"
                        Dekan={Ad="Mahmut";Soyad="Tuncer";DoğumYılı = None}
                    }
        BölümBaşkanı = {Ad="BB";Soyad="Bb";DoğumYılı=None}
        Sekreter = {Ad="S";Soyad="S";DoğumYılı=None}
        KayıtOluşturmaTarihi = System.DateTime.Now
}