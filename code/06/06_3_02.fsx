(* 06_3_02.fsx *)
// -------- Basit veri tipinen değişkenler --------

let metin : ref<string> = ref "Mahmut Tuncer"
let sayı = ref 42
printfn "İlk değer, sayı = %d" !sayı
// Çıktı : İlk değer, sayı = 42

sayı := !sayı + 1
printfn "Yeni değer, sayı = %d" !sayı
// Çıktı : Yeni değer, sayı = 43


// -------- Temel veri tipinen değişkenler --------

// Değer grubu
let grup = ref ("Ali",2)
printfn "İlk değer, grup  = %A" !grup
// Çıktı : İlk değer, grup = ("Ali",2)


grup := "Arda",1
printfn "Yeni değer, grup = %A" !grup
// Çıktı : Yeni değer, grup = ("Arda",2)


// Opsiyon
let opsiyon = ref (Some 1)
printfn "İlk değer, opsiyon  = %A" !opsiyon
// Çıktı : İlk değer, opsiyon = Some 1


opsiyon := Some 42
printfn "Yeni değer, opsiyon = %A" !grup
// Çıktı : Yeni değer, opsiyon = Some 42


// Liste
let liste = ref [1;2;3]
printfn "İlk değer, liste = %A" !liste
// Çıktı : İlk değer, liste = [1; 2; 3]

liste := [for i in 1..3 do yield 42]
printfn "Yeni değer, liste = %A" liste
// Çıktı : Yeni değer, liste = [42; 42; 42]

// Sekans
let sekans = ref (seq{for i in 1..3 do yield i})
printfn "İlk değer, sekans = %A" !sekans
// Çıktı : İlk değer, sekans = seq [1; 2; 3]

sekans := seq{for i in 1..3 do yield 42}
printfn "Yeni değer, sekans = %A" !liste
// Çıktı : Yeni değer, sekans = [42; 42; 42]



// -------- Özel veri tipinen değişkenler --------
type Kişi = {
    AdSoyad :string
    DoğumYılı: ref<int option>}

let kişi = {AdSoyad="Mahmut Tuncer";DoğumYılı= ref None}
printfn "İlk değer, kişi = %A" kişi
// Çıktı : İlk değer, kişi = {AdSoyad = "Mahmut Tuncer"; DoğumYılı = None;}

kişi.DoğumYılı := Some 1961
printfn "Yeni değer, kişi = %A" kişi
// Çıktı : Yeni değer, kişi = {AdSoyad = "Mahmut Tuncer"; DoğumYılı = Some 1961;}


