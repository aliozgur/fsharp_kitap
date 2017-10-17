(* 04_4_05.1.fsx *)

type Bilet = {
    Kalkış: string
    Varış: string
    Fiyat : decimal
} with

    // İlk üye fonksiyon.
    // indirimYüzde parametre elemanı opsiyonel, yani indirim yüzdesi 
    // belirtilmeden de bu fonksiyon ile işlem yapılabilir
    member this.indirimliFiyat (adet,?indirimYüzde) =
        if adet <= 0 then
            failwith "Geçersiz adet"

        let fiyat = this.Fiyat * decimal(adet)
        match indirimYüzde with
        | None -> fiyat 
        | Some i when i < 0M || i > 1M -> failwith "Geçersiz indirim oranı"
        | Some i -> fiyat - (fiyat * i)

    // İkinci üye fonksiyon. İlk fonksiyon ile aynı isimli
    // farklı olarak vergi isimli bir parametre elemanı tanımlı 
    member this.indirimliFiyat (adet,vergi,?indirimYüzde) =        
        let bazFiyat = match indirimYüzde with
            | None -> this.indirimliFiyat(adet)
            | Some i -> this.indirimliFiyat(adet,i)
      
        match vergi with
        | v when v > bazFiyat -> failwith "Vergi fazla olmamış mı?"
        | v when v <= 0M -> bazFiyat
        | _ -> bazFiyat + vergi
        
// TEST
let bilet = {Kalkış="İstanbul";Varış="Ankara";Fiyat=100M}

// İlk fonksiyon, indirimYüzde değeri verilmemiş
bilet.indirimliFiyat(3)
bilet.indirimliFiyat(3,0.1M)
// Fonksiyon parametreleri isimleri ile geçiliyor 
bilet.indirimliFiyat(adet=3,indirimYüzde=0.1M)


// İkinci fonksiyon çağırısı
bilet.indirimliFiyat(3,20M,0.1M)

// İkinci fonksiyon  çağırısı, indirimYüzde değeri verilmemiş
bilet.indirimliFiyat(adet=3,vergi=20M)
bilet.indirimliFiyat(adet=3,vergi=20M,indirimYüzde=0.1M)