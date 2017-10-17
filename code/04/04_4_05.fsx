(* 04_4_05.fsx *)

type İndirim = On|YirmiBeş|Yüz

type Bilet = {
    Kalkış: string
    Varış: string
    Fiyat : decimal
} with

    member this.indirimUygula (indirim:İndirim option) ekstraİndirim =
        let indirimliFiyat yüzde = this.Fiyat - (this.Fiyat * yüzde)
        
        let bazFiyat = 
            match indirim with
            | Some(On) -> (indirimliFiyat 0.1M) 
            | Some(YirmiBeş) -> (indirimliFiyat 0.25M) 
            | Some(Yüz) -> (indirimliFiyat 1M)
            | _ -> this.Fiyat

        let sonFiyat = 
            match ekstraİndirim with 
            | e when e < 0M -> bazFiyat
            | _ -> bazFiyat - (this.Fiyat * ekstraİndirim)

        match sonFiyat with
        | f when f < 0M -> 0M
        | _ -> sonFiyat

let bilet = {Kalkış="İstanbul";Varış="Ankara";Fiyat=240M}
bilet.indirimUygula (Some(On)) 0M
bilet.indirimUygula (Some(On)) 0.5M
bilet.indirimUygula (Some(On)) 1M


