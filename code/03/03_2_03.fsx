(*
| Operatör | Açıklama | Örnek | Sonuç|
|----------|----------|-------|------|
| **+** | Toplama | 1 + 2 | 3 |
| **-** | Çıkarma | 2-1 | 1 |
| **\*** | Çarpma | 3 * 4| 12 |
| **/** | Bölme | 4 / 2 | 2 |
| **\*\***|Kare | 2.0 ** 3.0 | 8 |
| **%** | Mod  | 4 % 3| 1 |
*)

(* 03_2_03.fsx *)

// 8-bit işretli tam sayı -128 ile 127 aralığında değer alabilir
let sonuç1 = 127y + 1y // Sonuç -128y
let sonuç2 = -128y - 1y // Sonuç 127y


// 32 bit işaretli tam sayı -32768 ile 32767 aralığında değer alabilir
let sonuç3 = 32767s + 1s // Sonuç -32768s
let sonuç4 = -32768s - 1s // Sonuç 32767s

// Çarpma işleminde aşım 
let sonuç5 = -128y * 3y // Sonuç -128y

// 2'li sayı düzeninde ifadeler ve aşım
let a = 0b01111111y // 127y
let b = 0b00000001y // 1y
let sonuç6 = a + b  // -128y

let a' = 0b10000000y // -128y
let b' = 0b11111111y // -1y
let sonuç7 = a' + b' // 127y 








