(* 04_3_01.fsx *)


type Renk = Kırmızı | Siyah

type Sembol = 
    | Kupa
    | Karo
    | Sinek
    | Maça

type İskambilKağıdı = 
    | As of Renk * Sembol 
    | Papaz of Renk * Sembol
    | Kız of Renk * Sembol
    | Vale of Renk * Sembol
    | Kart of Renk * Sembol * int 
    | Joker

// TEST

// Etket adı Kart, değeri de (Kırmısı,Karo,2) şeklindeki değer grubu
let kart = Kart (Kırmızı,Karo,2)
// Etiket adı Joker, değeri yok
let joker = Joker

// Etiket adı Kırmızı, değeri yok
let kırmızı = Kırmızı

// Değer kavrama ile deste oluşturuyoruz
let deste = Joker ::
                    [                      
                            let renk sembol =
                                match sembol with
                                    | Kupa | Karo -> Kırmızı
                                    | Sinek| Maça -> Siyah 

                            for sembol in [Kupa;Karo;Sinek;Maça] do 
                                let r = renk sembol
                                yield As (r,sembol)
                                yield Papaz (r,sembol)
                                yield Kız (r,sembol)
                                yield Vale (r,sembol)
                                for i in 2..10 do
                                    yield Kart (r,sembol,i)
                                
                    ]
