(* 03_5_01_null*)

open System


// Kişi isimli kayıt tipi tanımı
type Kişi = {Ad:string;Soyad:string}

// Yeni bir kişi oluşturma
let kişi = {Kişi.Ad="Ali"; Kişi.Soyad = "Özgür"}

// kişi' ifadesine null değer vermek mümkün değil 
//let kişi':Kişi = null

let tarihiÇözümle (str: string) =
    let (success, res) = DateTime.TryParse(str, null, System.Globalization.DateTimeStyles.AssumeUniversal)
    if success then
        Some(res)
    else
        None

tarihiÇözümle "2017-09-25 10:00:00"

// Araba isimli sınıf tanımı
[<AllowNullLiteral>]
type Araba (marka:string,model:string,modelYılı:int) = 
    member this.Marka = marka
    member this.Model = model
    member this.ModelYılı = modelYılı

let hondaCrv = Araba(marka="Honda",model="CRV",modelYılı=2017) 
let hondaHrv:Araba = null


let markayıGetir (a:Araba) : string = 
    if a = null then 
        "Geçerli bir araba örneği verilmemiş!"
    else 
        a.Marka


markayıGetir hondaCrv
markayıGetir hondaHrv


let nullMu değer = box değer = null
let nullMu' değer = isNull değer

nullMu hondaCrv
nullMu hondaHrv

nullMu' hondaCrv
nullMu' hondaHrv

