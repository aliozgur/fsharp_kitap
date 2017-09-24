(* 03_5_02.fsx *)

let yazar = ("Ali","Özgür",1979,9)
// Değer grubunun imzası şöyledir
// val yazar : string * string * int * int

// Değer tipleri tanımlı değer grubu
// Doğum günün kutlu olsun Ersel Özgür :)
let kardeş : string * string = ("Ersel","Özgür")

let baba = ("Ali","Özgür", ("Arda","Özgür"))

let çocuk = ("Arda","Özgür")

let çocukAd = fst çocuk
let çocukSoyad = snd çocuk

// Tüm değerleri ayrı ayrı birer ifadeye atayalım
let babaAd,babaSoyad,doğumYılı,doğumAyı = yazar

// Bazı değerleri _ ile sökme sırasında görmezden gelelim
let kişiAd,kişiSoyad,_ = baba
let kişiAd',_,çocuğu = baba


// Değer grubu parametresi alan fonksiyon
let topla (x,y) = x + y

topla (43,-1)

// Değer grubu parametresi alıp 
// değer grubu döndüren fonksiyon
let topla' (x,y) = 
    let t = x + y
    (t,sprintf "%d + %d = %d" x y t)

let toplam,metin = topla'(43,-1)

// Değer tipleri tanımlı değer grubu parametresi
let çarp ( (x,y):int*int ) : int * string = 
    let ç = x * y
    (ç,sprintf "%d * %d = %d" x y ç)

çarp (42,1)

let değerleriYazdır (x,y) = 
    printfn "Değerler x=%A, y=%A" x y
// Fonksiyonun imzası şöyledir
// val değerleriYazdır : x:'a * y:'b -> unit

değerleriYazdır (baba,çocuk)
değerleriYazdır (42,0)
