(* 04_4_01.fsx *)

type Kişi = {Ad:string;Soyad:string}
type Ürün = {Ad:string;BirimFiyat:decimal}
type Sipariş = {Ürün:Ürün;Adet:int}

type Sepet = {
    Müşteri:Kişi
    Siparişler:Sipariş list
    } with
    
    // MüşteriAdı isimli alan
    member this.MüşteriAdı = 
        sprintf "%s %s" this.Müşteri.Ad this.Müşteri.Soyad

    member self.tutarHesapla() = 
        self.Siparişler |> List.sumBy ( fun s -> s.Ürün.BirimFiyat * decimal(s.Adet) )

// TEST
// Kişi tipinden değer tanımlıyoruz
let kişi = {Ad="Mahmut";Soyad="Tuncer"}

// Siparişler listesini değer kavrama kullanarak 
// rastgele değerler ile oluşturuyoruz
let siparişler = [
    for i in 1..5 do
        for j in 1..i do
            match j with 
            | x when x % 2 = 0 -> yield 
                                    { 
                                      Ürün = { 
                                          Ad= sprintf "iPhone %d" j
                                          BirimFiyat=decimal(i*100)}
                                      Adet=j
                                    }
            | _ -> yield 
                                    {
                                        Ürün = {
                                            Ad= sprintf "iPad %d" j
                                            BirimFiyat=decimal(i*120)}
                                        Adet=j+1
                                    }      
]

let sepet = {Müşteri = kişi;Siparişler=siparişler}

// sepet değerinin üyelerini çağırıyoruz
sepet.MüşteriAdı
sepet.tutarHesapla()

