(* 07_3_01.fsx *)

type Dikdörtgen(x:int,y:int) = 
   
    // Değişkenler
    let mutable _sayaç = 0

    // Üye alanlar
    member this.X = x
    member this.Y = y
    member this.Sayaç = _sayaç

    member this.Alan = 
        this.X * this.Y
       
    member this.Çevre = 
        2*this.X + 2*this.Y
    
    member this.AlanHesapla() = 
        this.X * this.Y
       
    member this.ÇevreHesapla() = 
        2*this.X + 2*this.Y
    
    member this.SayacıArttır (değer:int):int = 
        if değer <= 0 then
            failwith "Değer sıfırdan büyük olmalı"
        _sayaç <- _sayaç + değer
        _sayaç

    member this.SayacıAzalt (değer:int) : int = 

        if değer <= 0 then
            failwith "Değer sıfırdan büyük olmalı"

        if değer >= _sayaç then
            _sayaç <- 0
        else
            _sayaç <- _sayaç - değer
         
        _sayaç
            
// TEST        
let dikdörtgen = Dikdörtgen(2,3)

dikdörtgen.AlanHesapla()
dikdörtgen.ÇevreHesapla()
dikdörtgen.SayacıArttır 44
dikdörtgen.SayacıAzalt 2

dikdörtgen.Sayaç
dikdörtgen.Alan
dikdörtgen.Çevre



