(* 01_0_03.fsx *)


// tek satırlık yorumlar için // kullanılır
(* 
    Birden fazla satırlı yorumlar için  
    (* *) çifti kullanılır
*)

// "let" anahtar kelimesi ile değeri 
// değiştirilemeyen (immutable) ifadeler tanımlanır
let sayı = 5
let ondalıkSayı = 3.14
let metin = "Merhaba Dünya!"

// İfadeleri `` `` arasında yazarak 
// F# anahtar kelimelerini de ifade adı
// olarak kullanabilirsiniz.
let ``let``= "F# ile Fonksiyonel Programlama"

// `` `` kullanarak boşluk içeren ifade isimleri 
// oluşturulabilir. Bu kullanım özellikle 
// birim testlerin (unit test) fonksiyon isimlerinde 
// oldukça faydalı olacaktır.
let ``Cümle gibi değer``="Cümle gibi değer ifadesinin değeri"

// F# değer ifadelerinin ismi olarak 
// UTF-8 karakterleri kullanılmasına izin verir.
let çÇşŞğĞüÜöÖİı = "Türkçe'ye özel karakterler"


// ======== Listeler ============
// Köşeli parantez ile liste tanımlanır
// liste elemanlarını ; ile ayrılır.
let pozitifSayılar = [1;2;3;4;5]        

//Elemanları 1 ile 100 arasındaki sayılar olan liste.
let liste100 = [1..100]

// Elamanları 1 ile 100 arasında olan ve 1'den itibaren
// 2 artarak oluşturulan sayılar olan liste.
let liste101 = [1..2..100]

// :: operatörü var olan listenin başına 
// 0 değerini ekleyerek yeni bir liste oluşturur.
// doğalSayılar listesinin içeriği [0;1;2;3;4;5] olur.
let doğalSayılar = 0 :: pozitifSayılar

// @ operatörü ile iki liste birleştirilip 
// yeni bir liste oluşturulur.
// tamSayılar listesinin içeriği [-5;-4;-3;-2;-1;0;1;2;3;4;5] 
// olur.
let tamSayılar = [-5;-4;-3;-2;-1] @ doğalSayılar   

// DİKKAT: liste ve dizilerin elemanlarını tanımlarken
// virgül yerine noktalu virgül kullanılır.

// ======== Fonksiyonlar ========
// "let" anahtar kelimesi ile değer ifadelerinin yanı sıra 
// ismi olan fonksiyonlar da tanımlanır.

// Fonksiyon tanımında parantez, süslü parantez veya 
// noktalı virgül kullanılmaz.
let küp x = x * x * x      

 // Fonksiyonu çalıştıralım.
 // Fonksiyona parametre geçerken parantez kullanmıyoruz!  
küp 3                      

// ekle fonksiyonunu çağırırken parametreleri geçmek için
// parantez kullanılmaz. 
// (1,2) 1 ve 2 değerlerini girdi olarak kullanmak anlamına gelmez
// (1,2) şeklindeki ifade ile değer grubu (tuple) tanımlanır.
let ekle x y = x + y        
ekle 2 3

// Birden fazla satıra yayılmış bir fonksiyon tanımlamak 
// için girintiler (indent) kullanılır. 
// Kod satırlarının bitişini belirtmek için ; kullanılmaz.
let çiftSayılar liste =
    // çiftMi fonksiyonunu iç fonksiyon olarak tanımla.
    let çiftMi x = x%2 = 0    

    // filter fonksiyonu List modülü içinde tanımlıdır.
    // filter girdi olarak bir fonksiyon parametresi ve 
    // bu fonksiyonu uygulayacağı listeyi alır.
    List.filter çiftMi liste    

// Fonksiyonu çalıştır.
çiftSayılar pozitifSayılar 


// Parantezleri işlem önceliğini belirtmek için kullanılabilir. 
// Parentezli ifadelerde öncelik içten dışa ve sağdan sola hesaplanır.
// Önce en içte ve sağdaki parantezli ifade çalıştırılır.

// Aşağıdaki örnekte önce List.map işleminin yapılması 
// sonra da List.sum işleminin yapılması isteniyor.
// Parantezler kullanılmazsa "List.map" fonksiyonu 
// "List.sum" fonksiyonuna ilk parametre olarak geçilmiş olur.
let küplerinToplamı =
   List.sum ( List.map küp [1..100] )

// Bir fonksiyonun çıktısını sonraki fonksiyona 
// "|>" (ileri aktarım) operatörü ile aktarılır.
// Küplerin toplamı fonksiyonu |> kullanılarak 
// aşağıdaki gibi de yazılabilir


// [1..100] listesini List.map fonksiyonuna 
// ikinci parametresi olarak aktar.
// List.map fonksyonunun birinci parametresi küp fonksiyonudur.
// List.map sonucunu List.sum fonksiyonuna girdi olarak aktar.
let küplerinToplamı2 =
   [1..100] |> List.map küp |> List.sum  

// "fun" anahtar kelimesini kullanılarak 
// adsız (anonim) fonksiyonlar tanımlanır.
let küplerinToplamı3 =
    // fun x -> x * x * x anonim bir fonksiyon tanımıdır.
   [1..100] |> List.map (fun x->x*x*x) |> List.sum


// Fonksiyonların içinde yerel fonksiyonlar tanımlanabilir.
let birArttır x = 
    // Yerel fonksiyon tanımı. 
    // Kabuk fonksiyon olan birArttır'ın parametrelerine erişebilir.
    let birArttırİçFonksiyon() = 
        x + 1

    // Yerel fonksiyonu kabuk fonksiyon içinden kullan.
    birArttırİçFonksiyon()

// Fonksiyonu çağır.
birArttır 2


// Öz yinelemeli fonksiyon tanımlamak için 
// "rec" anahtar kelimesi kullanılır.
// Aşağıdaki fonksiyon öz yinelemeli olarak 
// faktöriyel hesabı yapar.
let rec fact x = 
    if x <= 1 then 1 else x * fact (x - 1)

// F#'da fonksiyonların dönüş değerleri dolayılı olarak 
// belirlenir, bu nedenle değer döndürmek için "return" 
// benzeri bir anahtar kelimeye kullanılmaz.
// Bir fonksiyon bloğundaki son ifade her zaman dönüş değerini oluşturur.

// ======== Desen Eşleme (Pattern Matching) ========
// Desen eşleme için Match..with.. yapısı kullanılır.
let basitDesenEşleme =
   let x = 1
   match x with
    | 1 -> printfn "x'in değer 1"
    | 2 -> printfn "x'in değeri 2"
    // _ simgesi herhangi bir değeri eşlemek için 
    // yer tutucu olarak kullanılır
    | _ -> printfn "x'in değeri 1 veya 2 değil"   

// Some(<değer>) ve None, C benzeri dillerdeki null veya 
// Pascal benzeri dillerdeki nil değeri gibi düşünülebilir.
// F#'da Some/None dil yapısına option (opsiyon) denir.
let geçerliDeğer = Some(42)
let geçersizDeğer = None

// Aşağıdaki örnekte Some ve None desen eşleme ile 
// birlikte kullanılmaktadır. 
// Desen eşleme yaparken Some ifadesinin çevrelediği değeri
// kolayca söküp kullanabiliriz
let optionKullanarakEşleme girdi =
   match girdi with
    | Some i -> printfn "Girdi değeri = %d" i
    | None -> printfn "Girdi değer belirtilmemiş"

// Ekrana "Girdi değeri = 42" basılacak.
optionKullanarakEşleme geçerliDeğer

// Ekrana "Girdi değer belirtilmemiş" basılacak.
optionKullanarakEşleme geçersizDeğer

// ========= Karmaşık Veri Tipleri  =========

// Değer grupları (tuple) farklı tiplerde birden fazla 
// değer barındırabilir. 
// Değer grubu tanımlanırken virgül kullanılır.
let ikili = 1,2
let üçlü = "a",2,true

// Değer grupları tanımlarken parantez kullanımı opsiyoneldir
let dörtlü = ("a",2,true,System.DateTime.Now)

// Kayıt tiplerinin (record) alanları vardır.
// Alanları birbirinden ayrımak için noktalı virgül kullanılır.
type Öğrenci = {Ad:string; Soyad:string; Numara:int}

let öğrenci1 = {Ad="Arda"; Soyad="Özgür";Numara=124}

// Bileşimler (union) birden fazla seçenek tanımlanabilmesini sağlar. 
// Bunlara ayrışımlı bileşimler (discriminated union) de denir.
// Bileşimlerin seçenkleri dikine çizgi (|) simgesi ile birbirinden 
// ayrıştırılırlar.
type Derece = 
	| C of float
	| F of float
let dereceSantigrad = C 20.0
let dereceFahrenheit = F 68.0

type Kişi = {Ad:string;Soyad:string}
// Tipler öz yinelemeli olarak karmaşık yapılar (örneğin ağaç yapısı) 
// oluşturacak şekilde tanımlanabilir.
// Aşağıdaki örnekte İşçi ve Yönetici olarak ayrışan 
// öz yinelemeli bir bileşim tanımlanmıştır.
// Yönetici değer olarak Çalışan listesi alabilir.

type Çalışan = 
  | İşçi of Kişi
  | Yönetici of Çalışan list

let kişi = {Kişi.Ad="Ali";Soyad="Özgür"}
let işçi = İşçi kişi

// ========= Ekrana çıktı gönderme =========
// F# standard kütüphanesindeki printf/printfn fonksiyonları 
// ekrana metin yazedırmak için kullanılır
printfn "Bir int %i, bir float %f ve bir bool %b" 42 3.14 true
printfn "Metin %s ve tipi ile ilgilinemiyorum : %A" "Merhaba Dünya" [1;2;3;4;5]

// F# tüm karmaşık tipleri ekrana düzgün formatlayarak yazdırır
printfn "ikili=%A,\nkişi=%A,\nişçi=%A"  ikili kişi işçi

// Formatlanmış metni çıktı olarak döndürürmek için 
// F# standard kütüphanesindeki sprintf fonksiyonu kullanılabilir
let çıktı1 = sprintf "Bir int %i, bir float %f ve bir bool %b" 42 3.14 true
let çıktı2 = sprintf "Metin %s ve tipi ile ilgilinemiyorum : %A" "Merhaba Dünya" [1;2;3;4;5]
let çıktı3 = sprintf "ikili=%A,\nkişi=%A,\nişçi=%A"  ikili kişi işçi