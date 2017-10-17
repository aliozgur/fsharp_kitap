(* 04_5_01.fsx *)

// Doğrudan genelleme yapılan fonksiyon
let konsolaYazdır<'a> x =
    printfn "Değer : %A" x

// Doğrudan genelleme yapılan kayıt
type Kişi<'a,'b> = {
    Ad:string
    Soyad:string
    Değer1:'a
    Değer2:'b
} with

    // Doğrudan genelleme yapılan üye fonksiyon
    member this.konsolaYazdır<'a> x =
        printfn "Üye fonksiyon - Değer : %A" x

// Doğrudan genelleme yapılan ayrışık bileşim      
type İkiliSeçenek<'a,'b> = 
    | İlk of 'a
    | İkinci of 'b

// TEST

// Doğrudan genelleme yapılan fonksiyon
konsolaYazdır<int> 42
konsolaYazdır<float> 42.0
konsolaYazdır<bool> true
konsolaYazdır<string> "Mahmut Tuncer"

// Doğrudan genelleme yapılan kayıt
let kişi: Kişi<int,string> = {Ad="Arda";Soyad="Özgür";Değer1 = 4; Değer2="Berçin"}

// Doğrudan genelleme yapılan üye fonksiyon
kişi.konsolaYazdır<int> 42
kişi.konsolaYazdır<string> "Arda Özgür"

// Doğrudan genelleme yapılan ayrışık bileşim  

let seçenek1: İkiliSeçenek<int,string> = İlk 42
let seçenek2: İkiliSeçenek<int,string> = İkinci "Mahmut"

