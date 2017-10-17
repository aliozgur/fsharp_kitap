(* 05_8_01.fsx *)

#load "../_data/data.fsx"
open Data

// Data.Unemployment.Row  tipi için kısayol tip tanımı
type Satır = Data.Unemployment.Row 

let enYüksekOranıBul1 (işsizlikVerisi:Satır list) yıl =
    // yıl parametresine göre listeyi filtrele 
    let liste = işsizlikVerisi 
        |> List.filter( fun row -> int(row.Year) = yıl)
   
    // Öz yinelemeli yerel fonksiyon
    let rec f (max:Satır option) (l:Satır list) = 
        let ratio = 
            if Option.isSome(max) then 
                (Option.get max).Ratio 
            else 0.0
        
        match l with
        | [] -> max
        | baş::kuyruk -> 
            if baş.Ratio > ratio then
                f (Some(baş)) kuyruk
            else
                f max kuyruk

    // Yerel öz yinelemeli fonksiyonu çağırarak
    // döngüyü başlat
    f None liste

// İşsizlik verisini CSV dosyadan yükle
let işsizlikVerisi = Data.LoadData()

// Tüm yıllar için en yüksek işsizlik oranına sahip ülkeleri bul
[2010..2014] 
    |> List.map (enYüksekOranıBul1 işsizlikVerisi)   
    |> List.map( fun x -> Option.get x)

// Sonuç şöyle olur
(*
Satır list = [
    ("Bosnia and Herzegovina", "BIH", 2010, 57.20000076);
    ("Bosnia and Herzegovina", "BIH", 2011, 57.09999847);
    ("Bosnia and Herzegovina", "BIH", 2012, 61.70000076);
    ("Greece", "GRC", 2013, 58.0); 
    ("Spain", "ESP", 2014, 57.90000153)]
*)