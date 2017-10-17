(* 07_4_01.fsx *)

type Dikdörtgen(x:int,y:int) = 

    // Varsayılan private alan
    let mutable _sayaç = 0

    // Varsayılan public üye alan
    member this.X = x

    // public erişim seviyesi
    member public this.Y = y

    // private erişim seviyesi
    member private this.SayacıBirArttır() = 
        _sayaç <- _sayaç + 1

    // Aynı assembly içinden erişim seviyesi
    member internal this.Sayaç with
        set(v) = 
            _sayaç <- v
            this.SayacıBirArttır()

    member this.Sayaç' with
        get() = _sayaç
        and private set(v) = 
            _sayaç <- v
            this.SayacıBirArttır()

// Assembly seviyesinde erişilebilen sınıf 
type internal Dikdörtgen'() = 
    let x = 0

// Dışarıdan erişilemeyen sınıf
type private Dikdörtgen''() = 
    let x = 0

type Kare private (x:int) = 
    
    static member internal TarihVeSaat = System.DateTime.Now

    member this.X = x
    member this.Alan = x*x
    member this.Çevre = 4*x

    static member public Oluştur x = 
        Kare._Oluştur x

    static member private _Oluştur x = 
        Kare(x)

    public new() = 
        Kare(1)

// TEST
// Hata! 
// Varsayılan kurucu fonksiyon 
// dışarıya kapalı
//let kare = Kare(12)

let kare = Kare.Oluştur(12)
kare.X

let kare' = Kare()
kare'.X
