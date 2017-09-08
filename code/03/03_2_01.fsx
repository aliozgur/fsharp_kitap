(*
|**sbyte**| 8-bit işaretli tam sayı |System.SByte|1 byte|-128 ile 127 aralığınd	|42y, -11y|
|**byte** |	8-bit işaretsiz tam sayı|System.Byte |1 byte|0 ile 255 aralığında|42uy, 200uy|
|**int16**|	16-bit işaretli tam sayı|System.Int16|2 byte|-32768 ile 32767 aralığında|42s, -11s|
|**uint16**| 16-bit işaretsiz tam sayı|System.UInt16|2 byte|0 ile 65,535 aralığında|42us, 200us|
|**int/int32**| 32-bit işaretli tam sayı|System.Int32|4 byte|-2,147,483,648 ile 2,147,483,647 aralığında|	42, -11|
|**uint32**| 32-bit işaretsiz tam sayı|	System.UInt32|4 byte|0 ile 4,294,967,295 aralığında|42u, 200u|
|**int64**|	64-bit işaretli tam sayı|System.Int64|8 byte| -9,223,372,036,854,775,808 ile 9,223,372,036,854,775,807	aralığında | 42L, -11L|
|**uint64**| 64-bit işaretsiz tam sayı|System.UInt64|8 byte|0 ile 18,446,744,073,709,551,615 aralığında|42UL, 200UL|
|**bigint**|Rastgele uzunlukta tam sayı|System.Numerics.BigInteger| En az 4 byte| Herhangi bir tamsayı|	42I, 14999999999999999999999999I|
|**float32**|32-bit işaretli ondalık sayı (ondalık kısım 7 basamağa kadar)|System.Single| 4 byte|	±1.5e-45 ile ±3.4e38 aralığında|42.0F, -11.0F|
|**float**|64-bit işaretli ondalık sayı (ondalık kısım 15-16 basamağa kadar)|System.Double|	8 byte|	±5.0e-324 ile ±1.7e308 aralığında|42.0, -11.0|
|**decimal**|128-bit işaretli ondalık sayı (ondalık kısım 28-29 basamağa kadar)|System.Decimal|16 byte| ±1.0e-28 ile ±7.9e28 arasında|42.0M, -11.0M|
|**BigRational**|Rastegele uzunlukta rasyonel sayı. Kullanmak için FSharp.PowerPack.dll referans verilmesli|Microsoft.FSharp.Math.BigRational|En az 4 byte| Herhangi bir rasyonel sayı.|42N, -11N|
|**char**| Unicode karakter |System.Char| 2 byte| U+0000 ile U+ffff arasında|'x','\t'|
|**string**| Unicode metin|System.String| 20 + (2 * metnin uzunluğu) byte|0'den 2 miliyar adetkaraktere kadar|"Merhaba Dünya!", "F# ile fonksiyonel programlama"|
|**bool**|	Lojik 1 ve 0 | System.Boolean|1 byte|Sadece iki olası değer, true veya false|true,false|
*)

(* 03_2_01.fsx*)

// 64-bit işaretsiz tam sayı
let sayı = 42UL 

// 128-bit işaretli ondalık sayı
let pi = 3.1415926M 

// 64-bit işaretli ondalık sayı. e23 ifadesini on üzeri 23 olarak düşünmelisiniz.
let avagadro = 6.022e23 

// 1-bit true/false
let evet = true

// TAB kontrol karakteri \ simgesi kullanılarak tanımlanır
let tab = '\t' 
let tHarfi = 't'

//Yeni satır (NewLine) kontrol karakteri \ simgesi kullanılarak tanımlanır
let yeniSatır = '\n'
let nHarfi = 'n'

// string tipinden metin
let metin = "F# ile fonksiyonel programlama"

// Metin içinde özel karakter kullanımı
let metin2 = "ŞşİığĞüÜöÖ\t ve kontrol karakterleri kullanabilirim (TAB)\n Yeni satıra geçtik" 







