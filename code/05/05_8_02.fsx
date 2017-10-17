(* 05_8_02.fsx *)

#load "../_data/data.fsx"
open Data

// Data.Unemployment.Row  tipi için kısayol tip tanımı
type Satır = Data.Unemployment.Row 

let enYüksekOranıBul2 (yıl:int) : Satır =
    işsizlikVerisi 
    |> List.filter( fun r -> int(r.Year) = yıl) 
    |> List.maxBy ( fun r -> r.Ratio)
   

// İşsizlik verisini CSV dosyadan yükle
let işsizlikVerisi = Data.LoadData()
[2010..2014] |> List.map enYüksekOranıBul2

// Çıktı şöyle olur
(*
    Satır list =[
        ("Bosnia and Herzegovina", "BIH", 2010, 57.20000076);
        ("Bosnia and Herzegovina", "BIH", 2011, 57.09999847);
        ("Bosnia and Herzegovina", "BIH", 2012, 61.70000076);
        ("Greece", "GRC", 2013, 58.0); 
        ("Spain", "ESP", 2014, 57.90000153)]
*)