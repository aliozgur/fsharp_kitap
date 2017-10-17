(* 03_5_03.fsx *)

// ----- option tipinden değer tanımlama ----- 

let değer1 = Some(5)
let değer2 = None
let değer3 : int option = Some(5)

let değer4 : int option = None

let değer5 : (int list) option = None

// ----- option tipinden parametre kullanımı ----- 

// Araba isimli kayıt tipi
type Araba = {Marka:string;Model:string}

// None kontrolü ve Option.get kullanımı 
let arabaBilgisiniVer (a: Araba option):string = 
    if a = None then
        "Araba nesnesi belirtilmemiş"
    else
        let araba = Option.get a
        sprintf "Marka = %s, Model = %s" araba.Marka araba.Model

// Option.isNone ve Option.get kullanımı
let arabaBilgisiniVer' (a: Araba option):string = 
    if Option.isNone a then
        "Araba nesnesi belirtilmemiş"
    else
        let araba = Option.get a
        sprintf "Marka = %s, Model = %s" araba.Marka araba.Model


// Option.isSome ve Option.get kullanmı
let arabaBilgisiniVer'' (a: Araba option):string = 
    if Option.isSome a then
        let araba = Option.get a
        sprintf "Marka = %s, Model = %s" araba.Marka araba.Model
    else
        "Araba nesnesi belirtilmemiş"

let araba1 = None
let araba2 = Some({Marka="Honda";Model="CRV"})

arabaBilgisiniVer araba1
arabaBilgisiniVer araba2

arabaBilgisiniVer' araba1
arabaBilgisiniVer' araba2

arabaBilgisiniVer'' araba1
arabaBilgisiniVer'' araba2


// ----- option tipinden değer döndürme ----- 

let bölüm (x:float) (y:float) = x / y 

bölüm 5.0 0.0 // Sonuç : infinity 
bölüm 5.0 2.0 // Sonuç : 2.5

let bölüm' (x:float) (y:float) = 
    match y with
    | 0.0 -> None
    | _ -> Some(x / y)



bölüm' 5.0 0.0 // Sonuç : None
bölüm' 5.0 2.0 // Sonuç : Some(2.5)

// ----- option eşitliği ----- 

None = None // true
Some(1) = Some(1) // true
Some(1) = Some(2) // false
//Some(1) = Some("1") // Derleyici hatası, çevrelenen tipler farklı

