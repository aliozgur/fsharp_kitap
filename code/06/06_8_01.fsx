(* 06_8_01.fsx *)

// Saniye
[<Measure>] type sec

// Hertz
[<Measure>] type Hz = 1/sec

// Metre
[<Measure>] type m

// Santimetre
[<Measure>] type cm

// Kilogram
[<Measure>] type kg

// Kuvvet -> Newton
[<Measure>] type N = kg m/sec^2

// Hız
[<Measure>] type V = m/sec

[<Measure>] type a = m/sec^2


let birMetre = 1.0<m>
let birKilokram = 1<kg>
let birSaniye = 1<sec>

let birHertz = 1<Hz>

let altıNoktaÜçNewton = 6.3<N>

let sonuç = 6<m/sec> * 2<sec>
//val sonuç : int<m> = 12

let sonuç' = 12.0<m> / 2.0<sec>
//val sonuç' : float<m/sec> = 6.0


[<Measure>] type derece

let derece90 = 90<derece>
// sin fonksiyonu imzası (float -> float)

// Hatalı kullanım
//sin derece90

// Doğru kullanım
sin (float derece90)


let birimleriBöl (girdi1 : float<'a>) (girdi2:float<'b>) =
    girdi1 / girdi2


birimleriBöl 3.0<m> 1.2<sec>
// Çıktı : float<m/sec> = 2.5 

birimleriBöl 3.0<kg> 1.2<m^2>
// Çıktı :  float<kg/m ^ 2> = 2.5


type Dikdörtgen< [<Measure>] 'u >(x:float<'u>,y:float<'u>)= 
    member this.X = x
    member this.Y = y
    member this.SayısalX = float x
    member this.SayısalY = float y

    member this.AlanıHesapla() = this.X * this.Y

    member this.ÇevreyiHesapla() = 2.0*this.X + 2.0*this.Y 


// TEST
let dikdörtgen =  Dikdörtgen<_>(12.0<m>,42.0<m>)
let dikdörtgen' =  Dikdörtgen<cm>(12.0<cm>,42.0<cm>)
let dikdörtgen'' =  Dikdörtgen<cm>(12.0<_>,42.0<_>)

dikdörtgen.AlanıHesapla()
// Çıktı : float<m ^ 2> = 504.0
dikdörtgen.ÇevreyiHesapla()
// Çıktı : float<m> = 48.0

dikdörtgen'.AlanıHesapla()
// Çıktı : float<cm ^ 2> = 504.0
dikdörtgen'.ÇevreyiHesapla()
// Çıktı : float<cm> = 48.0


