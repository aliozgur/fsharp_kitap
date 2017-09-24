(* 03_5_06.fsx *)

// 3 satır ve 3 sütünlu matris oluştru.
// Hücre değerleri float tipinden
let floatMatrsi = Array2D.create<float> 3 3

// 3 satır ve 3 sütünlu matris oluştur.
// Hücre değerlerinin tipi int ve ilk değerleri 0
let intMatrsisi = Array2D.zeroCreate<int> 3 3

// 3 satır ve 3 sütünlu matris oluştur.
// Hücre değerlerinin tipi metin (string) ve hücre
// içeriği fonksiyon tarafından oluşturulur
let metinMatrisi2 = Array2D.init<string> 3 3 (fun r c -> sprintf "satır: %d, sütün: %d" r c)


let metinMatrisi1 = array2D [
    ["satır: 0, sütün 0";"satır: 0, sütün: 1";"satır: 0, sütün: 1"]
    ["satır: 1, sütün 0";"satır: 1, sütün: 1";"satır: 1, sütün: 1"]
    ["satır: 2, sütün 0";"satır: 2, sütün: 1";"satır: 2, sütün: 1"]]
