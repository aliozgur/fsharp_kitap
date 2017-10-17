(* 07_6_01.fsx *)

// Soyut sınıf
[<AbstractClass>]
type SoyutSınıf() = 
    abstract member Özellik1 : int
    abstract Özellik2: string with get,set
    abstract member Metod1: int -> string
    default this.Metod1 (değer:int) = sprintf "Değer = %d" değer

// Kontrat/ara birim
type IKontrat = 
    abstract member Özellik1 : int
    abstract Özellik2: string with get,set
    abstract member Metod1: unit -> string
    

// Kontrat/ara birim
type IMotor = 
    abstract member Özellik1 : int
    abstract Özellik2: string with get,set
    abstract member Metod1: unit -> string

// Kontrat/ara birim
type IYakıt = 
    abstract YakıtMiktarı : float with get,set

// Kontrat/ara birim ile uyumlu sınıf
type FosilYakıtMotoru(özellik1:int, özellik2:string) = 
    let mutable _özellik2 = özellik2
    let mutable _yakıtMiktarı = 0.0
    interface IMotor with
        member this.Özellik1 = özellik1    
        member this.Özellik2 with
            get() = _özellik2
            and set(v) = _özellik2 <- v
        member this.Metod1() = "Ben bir metodum"

    interface IYakıt with
        member val YakıtMiktarı = _yakıtMiktarı with get,set 


let fosil = FosilYakıtMotoru(1,"1")

// FosilYakıtMotoru tipinden nesneyi IMotor üst tipine dönüştür
let motor = fosil :> IMotor

// IMotor kontratındaki üye özellik ve metodları kullan
motor.Özellik1
motor.Metod1()

// FosilYakıtMotoru tipinden nesneyi IYakıt üst tipine dönüştür
let yakıt = fosil :> IYakıt

// IYakıt kontratındaki üye özellik ve metodları kullan
yakıt.YakıtMiktarı <- 47.0
yakıt.YakıtMiktarı


// Kontrat tipinden alan ve özellikler
type MotorAyrıntıları = {Motor:IMotor; Yakıt:IYakıt}

// Kontart üst tipine dolaylı dönüşüm yapılır
let motorAyrıntı = {Motor=fosil;Yakıt=fosil}

motorAyrıntı.Motor.Metod1()
motorAyrıntı.Yakıt.YakıtMiktarı <- 43.0
motorAyrıntı.Yakıt.YakıtMiktarı

// Kontrat tipinden fonksiyon parametresi 
let MotorMetodunuÇalıştır (motor:IMotor) = 
    motor.Metod1();

// Kontart üst tipine dolaylı dönüşüm yapılır
MotorMetodunuÇalıştır fosil
