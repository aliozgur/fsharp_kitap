(* 08_5_06.fsx *)

module Model =
    type Ürün = Ürün of string * float
    type ÜrünKategorisi = ÜrünKategorisi of string
    type KategoriListele = ÜrünKategorisi -> Ürün list
    type VeritabanıBağlantısı = VeritabanıBağlantısı of string
    type Dosya = Dosya of string

module Business = 
    open Model
    let kategoriÜrünleriniListele (list:KategoriListele) (kategori:ÜrünKategorisi) (minFiyat: float) (maxFiyat:float) = 
        let ürünler = list kategori
        let filtrele (ürün:Ürün) = 
            let f = match ürün with Ürün(a,f) -> f             
            f >= minFiyat && f <= maxFiyat
        
        ürünler |> List.filter filtrele
        
module Data = 
    open Model
    let veritabanındanKategoriListele  (db:VeritabanıBağlantısı) (kategori:ÜrünKategorisi) =
        let fakeÜrün i = Ürün (sprintf "Db Ürün %d" i, float i * 1.25)
        [1..5] |> List.map fakeÜrün

module Uygulama = 
    open Model
    open Business
    open Data

#if RELEASE
    // Canlı sistem 
    let db = VeritabanıBağlantısı "server=prod;db=..."   
#else
    // Test sistemi
    let db = VeritabanıBağlantısı "server=test;db=..."
 #endif
    let kategoriListele = veritabanındanKategoriListele db
    let ürünler = kategoriÜrünleriniListele kategoriListele  (ÜrünKategorisi "Spor") 0.0 100.0

module MockData = 
    open Model
    open Business
    let dosya = Dosya "/user/.../urun.xml"
    let dosyadanKategoriListele (dosya:Dosya) (kategori:ÜrünKategorisi) = 
        let fakeÜrün i = Ürün (sprintf "Dosya Ürün %d" i,float i * 1.25)
        [1..5] |> List.map fakeÜrün
    let kategoriListele = dosyadanKategoriListele dosya

module Test = 
    open Model
    open Business
    open MockData


    let ``her kategoride 5 ürün dönmeli`` () = 
        let ürünler = kategoriÜrünleriniListele kategoriListele (ÜrünKategorisi "Spor") 0.0 100.0
        ürünler.Length = 5

    let testSonuç = ``her kategoride 5 ürün dönmeli``()