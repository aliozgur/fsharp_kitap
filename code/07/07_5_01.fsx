[<AbstractClass>]
type Hayvan(tür:string) = 

    abstract member Ağırlık: float
    default this.Ağırlık = 0.0

    abstract Renk : string with get,set
    default this.Renk with 
        get() = ""
        and set(v) = ()

    member this.Tür = tür

    new() = 
        Hayvan("bilinmiyor")
    
    abstract member SesÇıkar : unit -> string

    default this.SesÇıkar() = 
        "???"

type Köpek(cinsi:string, ağırlık:float) =
    inherit Hayvan("köpek")
    let mutable _renk = ""

    member this.Cinsi = cinsi
    override this.Renk with
        get() = _renk
        and set(v) = _renk <- v
    override this.Ağırlık = ağırlık
    override this.SesÇıkar() = 
        let ses = base.SesÇıkar()
        let ağırlık = base.Ağırlık

        sprintf "Hav hav! base.SesÇıkar = %s, base.Ağırlık = %f" ses ağırlık


type Kedi(cinsi:string, ağırlık:float) =
    inherit Hayvan("kedi")
    let mutable _renk = ""

    member this.Cinsi = cinsi
    override this.Renk with
        get() = _renk
        and set(v) = _renk <- v
    override this.Ağırlık = ağırlık
    override this.SesÇıkar() =
        sprintf "Miyav miyav!"


let k = Köpek("Golden",21.2)
k.Tür
k.Cinsi
k.Ağırlık

k.Renk <- "Sarı"
k.Renk

let köpek = Köpek("Golden",21.2)
let kedi = Kedi("Van",4.5)
let SesÇıkar (hayvan:Hayvan) = 
    hayvan.SesÇıkar()
// TEST
SesÇıkar köpek
SesÇıkar kedi


