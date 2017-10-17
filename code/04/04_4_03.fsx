(* 04_4_03.fsx*)

type Kişi = {Ad:string;Soyad:string} with
    
    // Değer üzerinden erişip kullanabileceğimiz üye
    member this.TamAdı = sprintf "%s %s" this.Ad this.Soyad

    // Tip ismi kullanarak erişebileceğimiz static üye
    static member Oluştur ad soyad = 
        {Ad=ad;Soyad=soyad}

// TEST

// Kişi tipi için tanımladığımız static Oluştur fonksiyonu
// kullanılarak yeni bir kişi değeri oluşturduk
let kişi = Kişi.Oluştur "Mahmut" "Tuncer"

// Değer üzerinden TamAdı üye alanını kullandık
kişi.TamAdı
