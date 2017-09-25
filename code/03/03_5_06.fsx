(* 03_5_06.fsx *)

// ------------ Array2D Modülü ------------

// 3 satır ve 3 sütünlu matris oluştru.
// Hücre değerleri float tipinden
let floatMatrisi = Array2D.create<float> 3 3

// 3 satır ve 3 sütünlu matris oluştur.
// Hücre değerlerinin tipi int ve ilk değerleri 0
let intMatrisi = Array2D.zeroCreate<int> 3 3

// 3 satır ve 3 sütünlu matris oluştur.
// Hücre değerlerinin tipi metin (string) ve hücre
// içeriği fonksiyon tarafından oluşturulur
let metinMatrisi = Array2D.init<string> 3 3 (fun r c -> sprintf "satır: %d, sütün: %d" r c)


// ------------ array2D operatörü ------------
let metinMatrisi1 = array2D [
    ["satır: 0, sütün 0";"satır: 0, sütün: 1";"satır: 0, sütün: 1"]
    ["satır: 1, sütün 0";"satır: 1, sütün: 1";"satır: 1, sütün: 1"]
    ["satır: 2, sütün 0";"satır: 2, sütün: 1";"satır: 2, sütün: 1"]]


// ------------ 2 Boyutlu Dizi Hücre Erişimi ve Kesit Alma ------------
// 1. satır, 1. sütündaki hücrenin değerini sök
metinMatrisi.[1,1]

// tüm satırlar, sadece 0. ve 1. sütünlar 
metinMatrisi.[*,0..1]

// Tüm sütünlar, sadece 0. ve 1. satırlar
metinMatrisi.[0..1,*]

// 1. sütündan sonraki tüm sütünlar, tüm satırlar
metinMatrisi.[1..,*]

// 1. sütüna kadarki tüm sütünlar, tüm satırlar
metinMatrisi.[..1,*]

// 1. ve 2. satır, 0. ve 1. sütünlar
metinMatrisi.[1..2,0..1]

// 1. satır'ı dizi olarak sök
metinMatrisi.[1,*]

// 1. sütün'u dizi olarak sök
metinMatrisi.[*,1]

// ------------ Düzensiz Diziler ------------


let düzensizSayıDizsi = [|
    [|1;2|]
    [|3;4;5|]
|]

let düzensizMetinDizisi: string[][] = [| [|"A";"B"|] ; [|"C";"D";"E"|] |]

let düzensizMetinDizisi': string[][] = [|
    [|"A";"B"|]
    [|"C";"D";"E"|] |]


// ------------ Düzensiz Diziler - Değer Kavrama İfadeleri  ------------

let düzensizDizi1 = [|
    for i in 1..5 do   
        yield [|
            for k in 1..i do 
                yield k
          |]
|]

let düzensizDizi2 = [|
    for i in 1..5 do   
        yield Array.init<string> i ( fun i -> sprintf "Değer %d" i)
|]