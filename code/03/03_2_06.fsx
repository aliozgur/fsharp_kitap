(* 03_2_06.fsx *)
let tekTırnak = '\''
let çiftTırnak = '\"'
let geriBölü = '\\'
let tab = '\t'
let yeniSatır = '\n'
let satırBaşı = '\r'

printfn "tek tırnak %c, çift tırnak %c" tekTırnak çiftTırnak

// 'a' karakterinin sayısal unicode değeri 
// int dönüşüm fonksiyonu kullanılarak elde edilir
let a = int 'a'

// 'a' karakterinin 8 bitlik işaretsiz sayı karşılığı
// karakter tanımının sonuna B koyarak elde edilir
let bitmap = 'a'B