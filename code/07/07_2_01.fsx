(* 07_2_01.fsx *)

type Dikdörtgen(x:int,y:int) as this = 
    
    // Statik alan
    static let mutable _tarih = 0
    
    let mutable _sayaç = 0
    
    [<DefaultValue>]
    val mutable _renk : string

    // Statik üye alanlar
    static member Tarih = _tarih

    static member Tarih'
        with get() = _tarih
        and set(v) = _tarih <- v
    
    static member val Sayaç'' = _tarih with get,set


    // Üye alanlar
    member this.X = x
    member this.Y = y
    member this.Alan = x * y
    member this.Çevre = 
        let topX = 2 * this.X
        let topY = 2 * this.Y
        topX + topY
   
    member this.Sayaç with
        get() = _sayaç
        and set(v) = _sayaç <- v
    member this.Sayaç' with
        set(v) = _sayaç <- v

    member val Renk = "Beyaz" with get,set
    member val Renk' = "Beyaz"

    new(a:int,b:int,renk:string) as this = 
        Dikdörtgen(a,b)
        then
            this._renk <- renk

type Dikdörtgen' = 
    val x:int
    val y:int
    
    new(en,boy) = {x=en;y=boy}
    new(en) = {x=en;y=en}

    member this.X = this.x
    member this.Y = this.y


// TEST

let dikdörtgen = Dikdörtgen(2,3)
dikdörtgen.X
dikdörtgen.Y
dikdörtgen.Alan
dikdörtgen.Çevre

dikdörtgen.Sayaç <- 1
dikdörtgen.Sayaç

dikdörtgen.Sayaç' <- 2
dikdörtgen.Sayaç

dikdörtgen.Renk <- "Kırmızı"
dikdörtgen.Renk
dikdörtgen.Renk'

let dikdörtgen' = Dikdörtgen(2,3,"Yeşil")