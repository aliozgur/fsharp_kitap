
(* 07_7_01.fsx *)

// -----------------------------------------------------------
// ----------------- KALITIM HİYERARŞİSİ ----------------- 
// -----------------------------------------------------------

type AtanınAtası() = 
    abstract member AtanınAtasıMetod: unit -> string
    default this.AtanınAtasıMetod() = "AtanınAtası metodu."

type Ata() = 
    inherit AtanınAtası()

    abstract member AtanınMetodu: unit -> string
    default this.AtanınMetodu() = "Ata metodu."

type AlakasızAta() = 
    inherit AtanınAtası()
    abstract member AlakasızAtaMetodu: unit -> string
    default this.AlakasızAtaMetodu() = "Ata metodu."


type Türeyen() = 
    inherit Ata()
    member this.TüreyeninMetodu() = "Türeyen metodu"


// -----------------------------------------------------------
// ----------------- ÜST TİP DÖNÜŞÜMÜ - TEST ----------------- 
// -----------------------------------------------------------

let türeyen = Türeyen()
let ata = türeyen :> Ata
let atanınAtası = türeyen :> AtanınAtası

// Derleyici hatası
//let alakasızAta = türeyen :> AlakasızAta

// Hata, let ifadelerde dolaylı üst tipe dönüşüm yapılmaz
//let ata : Ata = türeyen
//let atanınAtası : AtanınAtası = türeyen

// Üst tipe dolaylı dönüşüm
let AtaİleİşlemYap (ata:Ata) = 
    ata.AtanınMetodu()

let AtanınAtasıİleİşlemYap (atanınAtası:AtanınAtası) = 
    atanınAtası.AtanınAtasıMetod()

AtaİleİşlemYap türeyen
AtanınAtasıİleİşlemYap türeyen

// -----------------------------------------------------------
// ----------------- ALT TİP DÖNÜŞÜMÜ - TEST ----------------- 
// -----------------------------------------------------------

type Türeyen'() = 
    inherit Ata()
    member this.TüreyeninMetodu'() = "Türeyen' metodu"


let TüreyenİleİşlemYap (ata:Ata) =
    let türeyen = ata :?> Türeyen
    türeyen.TüreyeninMetodu()


// İlk çağırı
let ata1 = türeyen :> Ata
TüreyenİleİşlemYap ata1

// İkinci çağırı

let türeyen' = Türeyen'()
let ata2 = türeyen' :> Ata
TüreyenİleİşlemYap ata2