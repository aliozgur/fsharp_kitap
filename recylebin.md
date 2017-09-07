# Recyclebin

### F# Version History

| Versiyon | Tarih       | Platform Desteği | .NET Versiyonu | Geliştirme Araçları      |
|----------|-------------|-------------------------|----------------|--------------------------|
| F# 1.x   | 2005 - Mayıs| Windows                 | .NET 1.0 - 3.5 | Visual Studio 2015, Emacs|
| F# 2.0   | 2010 - Nisan| Windows, Linux, OSX     | .NET 2.0 - 4.0, Mono|Visual Studio 2010, Emacs|
| F# 3.0   | 2012 - Ağustos|Windows, Linux, OSX, JavaScript,GPU| .NET 2.0 - 4.5, Mono|Visual Studio 2012, Emacs, WebSharper|
| F# 3.1   | 2013 - Ekim|Windows, Linux, OSX, JavaScript,GPU| .NET 2.0 - 4.5, Mono|Visual Studio 2013, Emacs, WebSharper, MonoDevelop, Xamarin Studio, CloudSharper|
| F# 4.0   | 2015 - Temmuz|Windows, Linux, OSX, JavaScript,GPU| .NET 2.0 - 4.5, Mono|Visual Studio 2013, Emacs, WebSharper, MonoDevelop, Xamarin Studio, CloudSharper|
| F# 4.1   | 2017 - Mart|Windows, Linux, OSX, JavaScript,GPU| .NET 3.5 - 4.6.2, .NET Core, Mono|Visual Studio 2017, Ionide, Visual Studio Code, Atom, Rider, Web Sharper, Visual Studio for Mac|

### Özel Fonksiyonlar

Fonksiyon tanımında verdiğimiz her iki koşulu sağlamakla birlikte farklı kurallar uygulanarak birim (özdeşlik) fonksiyon, sabit fonksiyon, örten fonksiyon ve kısıtlama fonksiyonu gibi özel fonksiyon tanımları da yapılır. Bu özel fonksiyon tanımları fonksiyonların ilginç özelliklerine değineceğimiz bölümün de düşünsel altyapısını oluşturması açısından önemlidir. 

Özel fonksiyon tanımlarını ele almadan önce **tanım kümesi**, **değer kümesi** ve **görüntü kümesi** Kavramlarını aşağıdaki diagram ile açıklayalım

![](/img/01_02_01_b.jpg)

Yukarıdaki şekilde 
* Tanım Kümesi A : A{1,2,3}
* Değer Kümesi B : B{a,b,c,d}
* Görüntü Kümesi : f(A) = {a,d}
f fonksiyonunun da  f(A) = {(1,a),(2,a),(3,d)} olarak tanımlanır

Şimdi gelin bu özel fonksiyonlardan bazılarını tanımlayıp basit örnekler ile somutlaştıralım.

**Birim (Özdeşlik) Fonksiyonu**: X bir küme ve f X'den X'e (f: X -> X) bir fonksiyon olsun. X kümesindeki tüm x değerlerini yine X kümesindeki aynı x değeri ile eşleştiren fonksiyona birim fonksiyon denir. f(1) = 1, f(2) = 2 ve f(100) = 100 şeklindeki fonksiyonlar birim fonksiyondur. 

![](/img/01_02_02.jpg)

Örneğin, f(x) = (2n-4) * x² + (2m - 5) * x + m + n + k şeklinde tanımı bir birim fonksiyon ise f(x) = x olması için **(2n-4) = 0** , **(2m - 5) = 1** ve **m + n + k = 0** olmalıdır


**Sabit Fonksiyon**: X,Y≠∅ birer küme ve f X'den Y'ye bir fonksiyon olsun. X kümesinin tüm x değerleri Y kümesindeki tek bir c değeri ile eşleşiyorsa f fonksiyonuna sabit fonksiyon denir.

![](/img/01_02_03.jpg)

**Örten Fonksiyonu**: Görüntü kümesi değer kümesine eşit olan fonksiyona örten fonksiyon denir.X bir küme, ∅≠A⊂X olsun. iA:A→X ∀a∈A,f(a)=a biçiminde tanımlanan dönüşüme A kümesinin X'deki içerme fonksiyonu denir.

![](/img/01_02_04.jpg)

Yukarıdaki şekilde **f** fonksiyonu örten fonksiyondur çünkü Y değer kümesinde X tanım kümesinden bir eleman ile eşlenmemiş hiç bir eleman yoktur (görüntü ve değer kümesi eşit). Ancak **g** fonksiyonu örten fonksiyon değildir çünkü B değer kümesinde A tanım kümesindeki bir eleman ile eşlenmemiş iki değer vardır (görüntü kümesi değer kümesinden farklı).

**İçine Fonksiyon** : Görüntü kümesi değer kümesinin özalt kümesi olan fonksiyonlara içine fonksiyon denir. Örten fonksiyon örnek diagramındaki g fonksiyonu içine fonksiyondur çünkü g fonksiyonun görüntü kümesi olan {1,2,3} kümesi B değer kümesinin ({1,2,3,4,5}) bir özalt kümesidir.

## Basit Veri Tipleri

| F# tipi | Açıklama | .NET Tipi | Bellek Miktarı | Değer Aralığı | Örnek | 
|---|---|---|---|---|---|
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

