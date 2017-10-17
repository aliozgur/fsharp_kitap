(* 07_1_01.fsx *)

type Dikdörtgen(x:int,y:int) as this =
   
    // Statik değer
    static let tarihSaat = System.DateTime.Now

    // Değerler
    let _x = x
    let _y = y

    [<DefaultValue>]
    val mutable Alan : int

    // Değişkenler
    let mutable _sayaç = 0

    // Üye alanlar
    member this.X = x
    member this.Y = y
    member this.Sayaç = _sayaç
   
    // İlklendirme kod bloğu
    do 
        let zaman = System.DateTime.Now
        printfn "Dikdörtgen oluşturuluyor. %A" zaman
    
    do 
        printfn "X=%d, Y=%d"  this.X this.Y

    do
        this.Alan <- this.X * this.Y

    // Statik ilklendirme kodu 
    static do
        printfn "Sınıf ilk defa kullanılıyor. %A" tarihSaat


    // İlave kurucu fonksiyon
    new(a) as this = 
        Dikdörtgen(a,a)
        then
            printfn "Dikdörtgen oluşturuldu." 
            printfn "Parametre = %d : X=%d,Y=%d" a this.X this.Y

    // Statik fonksiyon
    static member MesajGöster() =
        printfn "Statik metod içinden mesaj"

    // Üye metodlar
    member this.SayaçBirArttır() = 
        _sayaç <- _sayaç + 1
    
    member this.SayaçBirAzalt() = 
        _sayaç <- _sayaç - 1

type Dikdörtgen' = 
    val x:int
    val y:int
    
    new(en,boy) = {x=en;y=boy}
    new(en) = {x=en;y=en}

// TEST
Dikdörtgen.MesajGöster()

let dikdörtgen = Dikdörtgen(2,3)
let dikdörtgen' = Dikdörtgen(2)

let dikdörtgen''= Dikdörtgen'(2,3)
let dikdörtgen'''= Dikdörtgen'(2)

dikdörtgen.Alan
dikdörtgen.SayaçBirArttır()
dikdörtgen.SayaçBirArttır()
dikdörtgen.Sayaç


