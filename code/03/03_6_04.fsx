(* 03_6_04.fsx *)

// ---- Değer Grupları (tuple) Eşitliği ve Karşılaştırma ---- 
let değerGrubu1 = (1,2)
let değerGrubu2 = (1,2)
let değerGrubu3 = (2,1)
let değerGrubu4 = (2,3)

değerGrubu1 = değerGrubu2 // true
değerGrubu1 = değerGrubu3 // false

değerGrubu1 < değerGrubu3 // true
değerGrubu4 > değerGrubu3 // true


// ---- Liste (list) Eşitliği ve Karşılaştırma ---- 
let liste1 = [1..5]
let liste2 = [1..5]
let liste3 = [
    for i in 1..5 do
        if i = 1 then
            yield 2
        else if i = 2 then 
            yield 1
        else 
            yield i
]

let liste4 = [
    for i in 1..5 do
        if i = 2 then
            yield 0
        else 
            yield i
]

liste1 = liste2 // true
liste1 = liste3 // false
liste3 > liste1 // true
liste4 > liste1 // false

// ---- Dizi (Array) Eşitliği ve Karşılaştırma ---- 
let dizi1 = [1..5]
let dizi2 = [1..5]
let dizi3 = [
    for i in 1..5 do
        if i = 1 then
            yield 2
        else if i = 2 then 
            yield 1
        else 
            yield i
]

let dizi4 = [
    for i in 1..5 do
        if i = 2 then
            yield 0
        else 
            yield i
]


dizi1 = dizi2 // true
dizi1 = dizi3 // false
dizi3 > dizi1 // true
dizi4 > dizi1 // false


// ---- Opsiyon (option)  Eşitliği ve Karşılaştırma ---- 
let opsiyon1 = Some(1)
let opsiyon2 = Some(1)
let opsiyon3 = Some(2)

opsiyon1 = opsiyon2 // true
opsiyon1 = opsiyon3 // false
opsiyon3 > opsiyon1 // true


// ---- Kayıt (Record) Eşitliği ve Karşılaştırma ---- 
type Kişi = {Ad:string;Soyad:string;DoğumYılı:int}

// kişi1, kişi2 ve kişi3 değerler
let kişi1 = {Ad="Ali";Soyad="Özgür";DoğumYılı=1979}
let kişi2 = {Ad="Ali";Soyad="Özgür";DoğumYılı=1979}
let kişi3 = {Ad="Ali";Soyad="Özgür";DoğumYılı=1980}
let kişi4 = {Ad="Arda";Soyad="Özgür";DoğumYılı=1979}

kişi1 = kişi2 // true
kişi1 = kişi3 // false

kişi1 < kişi3 // true 
kişi1 < kişi4 // true

// ---- Çatı (struct)  Eşitliği ve Karşılaştırma ---- 

type Nokta = 
    struct
        val x: float
        val y: float
        new(x,y) = {x=x;y=y}
    end

let nokta1 = Nokta(1.0,0.0)
let nokta2 = Nokta(1.0,0.0)

let nokta3 = Nokta(1.0,2.0)
let nokta4 = Nokta(2.0,0.0)

let nokta5 = Nokta(0.0,2.0)

nokta1 = nokta2 // true
nokta1 = nokta3 // false
nokta1 = nokta4 // false
nokta3 > nokta1 // true
nokta4 > nokta1 // true
nokta5 > nokta1 //false

// ---- Bileşimler (union)  Eşitliği ve Karşılaştırma ---- 

type Şehir = Adana|Bursa|İstanbul

let bursa = Bursa
let bursa' = Bursa
let adana = Adana
let istanbul = İstanbul

bursa = bursa' // true
bursa = adana // false
bursa = istanbul // false
bursa > adana // true
adana > istanbul // false
