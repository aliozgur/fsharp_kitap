# Recyclebin

### Özel Fonksiyonlar

Fonksiyon tanımında verdiğimiz her iki koşulu sağlamakla birlikte farklı kurallar uygulanarak birim (özdeşlik) fonksiyon, sabit fonksiyon, örten fonksiyon ve kısıtlama fonksiyonu gibi özel fonksiyon tanımları da yapılır. Bu özel fonksiyon tanımları fonksiyonların ilginç özelliklerine değineceğimiz bölümün de düşünsel altyapısını oluşturması açısından önemlidir. 

Özel fonksiyon tanımlarını ele almadan önce **tanım kümesi**, **değer kümesi** ve **görüntü kümesi** Kavramlarını aşağıdaki diagram ile açıklayalım

![](/img/01_01_01_b.jpg)

Yukarıdaki şekilde 
* Tanım Kümesi A : A{1,2,3}
* Değer Kümesi B : B{a,b,c,d}
* Görüntü Kümesi : f(A) = {a,d}
f fonksiyonunun da  f(A) = {(1,a),(2,a),(3,d)} olarak tanımlanır

Şimdi gelin bu özel fonksiyonlardan bazılarını tanımlayıp basit örnekler ile somutlaştıralım.

**Birim (Özdeşlik) Fonksiyonu**: X bir küme ve f X'den X'e (f: X -> X) bir fonksiyon olsun. X kümesindeki tüm x değerlerini yine X kümesindeki aynı x değeri ile eşleştiren fonksiyona birim fonksiyon denir. f(1) = 1, f(2) = 2 ve f(100) = 100 şeklindeki fonksiyonlar birim fonksiyondur. 

![](/img/01_01_02.jpg)

Örneğin, f(x) = (2n-4) * x² + (2m - 5) * x + m + n + k şeklinde tanımı bir birim fonksiyon ise f(x) = x olması için **(2n-4) = 0** , **(2m - 5) = 1** ve **m + n + k = 0** olmalıdır


**Sabit Fonksiyon**: X,Y≠∅ birer küme ve f X'den Y'ye bir fonksiyon olsun. X kümesinin tüm x değerleri Y kümesindeki tek bir c değeri ile eşleşiyorsa f fonksiyonuna sabit fonksiyon denir.

![](/img/01_01_03.jpg)

**Örten Fonksiyonu**: Görüntü kümesi değer kümesine eşit olan fonksiyona örten fonksiyon denir.X bir küme, ∅≠A⊂X olsun. iA:A→X ∀a∈A,f(a)=a biçiminde tanımlanan dönüşüme A kümesinin X'deki içerme fonksiyonu denir.

![](/img/01_01_04.jpg)

Yukarıdaki şekilde **f** fonksiyonu örten fonksiyondur çünkü Y değer kümesinde X tanım kümesinden bir eleman ile eşlenmemiş hiç bir eleman yoktur (görüntü ve değer kümesi eşit). Ancak **g** fonksiyonu örten fonksiyon değildir çünkü B değer kümesinde A tanım kümesindeki bir eleman ile eşlenmemiş iki değer vardır (görüntü kümesi değer kümesinden farklı).

**İçine Fonksiyon** : Görüntü kümesi değer kümesinin özalt kümesi olan fonksiyonlara içine fonksiyon denir. Örten fonksiyon örnek diagramındaki g fonksiyonu içine fonksiyondur çünkü g fonksiyonun görüntü kümesi olan {1,2,3} kümesi B değer kümesinin ({1,2,3,4,5}) bir özalt kümesidir.