// tek satırlık yorumlar için // kullanılır
(* 
    Birden fazla satırlı yorumlar için  (* *) çifti kullanılır
*)

// "let" anahtar kelimesi ile değeri değiştirilemeyen (immutable) değer ifadeleri tanımlanır
let sayı = 5
let ondalıkSayı = 3.14
let metin = "Merhaba Dünya!"

// Değer ifadelerini `` `` arasında yazarak F# anahtar kelimelerini de 
// değer ifadesi adı olarak kullanabilirsiniz
let ``let``= "F# ile Fonksiyonel Programlama"

// `` `` kullanarak boşluk içeren değer ifadesi isimleri oluşturabilirsiniz.
// Bu kullanım özellikle birim test (unit test) yazıyorsanız oldukça faydalı olacaktır
let ``Cümle gibi değer``="Cümle gibi değer ifadesinin değeri"

// F# değer ifadelerinin ismi olarak UTF-8 karakterleri kullanılmasına izin verir
let çÇşŞğĞüÜöÖİı = "Türkçe'ye özel karakterler"


// ======== Listeler ============
// Köşeli parantez ile liste tanımlanır
// liste elemanlarını da ; ile ayrırırıs
let pozitifSayılar = [1;2;3;4;5]        

// :: operatörü varolan listenin başına 0 değerini ekleyerek yeni bir liste oluşturur
// doğalSayılar listesi [0;1;2;3;4;5] şeklinde olacaktır
let doğalSayılar = 0 :: pozitifSayılar

// @ operatörü iki listeyi birleştirip yeni bir liste oluşturur
// tamSayılar listesi [-5;-4;-3;-2;-1;0;1;2;3;4;5] şeklinde olacaktır
let tamSayılar = [-5;-4;-3;-2;-1] @ doğalSayılar   

// DİKKAT: liste ve dizilerin elemanlarını tanımlarken virgül yerine noktalu virgül kullanılır

// ======== Fonksiyonlar ========
// "let" anahtar kelimesi ile aynı zamanda ismi olan fonksiyonlar da tanımlanır

// Fonksiyon tanımında parantez, süslü parantez veya noktalı virgül kullanılmıyor
let küp x = x * x * x      
 // Fonksiyonu çalıştıralım, girdi parametrelerini tanımlarken de parantez kullanmıyoruz  
küp 3                      

// ekle fonksiyonunu çağırırken ekle (1,2) şeklinde girdi parametreleri için parantez kullanmayın
// (1,2) 1 ve 2 parametrelerini girdi olarak vermek anlamına gelmez
// (1,2) şeklindeki ifade ile değer grubu (tuple) tanımlanır
let ekle x y = x + y        
ekle 2 3

// Birden fazla satıra yayılmış bir fonksiyon tanımlamak için girintiler (indent) kullanılır. 
// Kod satırlarının bitişini belirtmek için ; kullanılmaz
let çiftSayılar liste =
    // çiftMi fonksiyonunu iç fonksiyon olarak tanımla
    let çiftMi x = x%2 = 0      
    // List.filter standard List modülünde yer alan hazır bir fonksiyon
    // List.filter girdi olarak bir fonksiyon parametresi ve bu fonksiyonu çalıştıracağı listeyi alır
    List.filter çiftMi liste    

// Fonksiyonu çalıştır
çiftSayılar pozitifSayılar 

// Parantezleri işlem önceliğini belirtmek için kullanabilirsiniz. Aşağıdaki örnekte
// önce List.map işleminin yapılmasını sonra da List.sum işleminin yapılmasını belirtiyoruz
// Parantezler kullanmasaydık "List.map" fonksiyonu "List.sum" fonksiyonuna 
// birinci girdi parametresi olarak geçilecekti
let küplerinToplamı =
   List.sum ( List.map küp [1..100] )

// Bir fonksiyonun çıktısını sonraki fonksiyona "|>" operatörü ile aktarabilirsiniz
// Küplerin toplamı fonksiyonun |> kullanan yeni hali aşağıdaki gibidir

// 1 ile 100 arasındaki değer listesini List.map fonksiyonuna 
// ikinci girdi parametresi olacak şekilde aktar
// List.map fonksyonunun birinci girdi parametresi ise küp fonksiyonudur
// List.map sonucunu List.sum fonksiyonuna girdi parametresi olarak aktar 
let küplerinToplamı2 =
   [1..100] |> List.map küp |> List.sum  

// "fun" anahtar kelimesini kullanarak adsız (anonim) fonksiyonlar tanımlayabilirsiniz
let küplerinToplamı3 =
    // fun x -> x * x * x anonim bir fonksiyon tanımıdır
   [1..100] |> List.map (fun x->x*x*x) |> List.sum


// Fonksiyonların içinde yerel fonksiyonlar tanımlayabiliriz
let birArttır x = 
    // Yerel fonksiyon. Kabuk fonksiyonun parametrelerine erişir
    let birArttırİçFonksiyon() = 
        x + 1

    // Yerel fonksiyonu kabuk fonksiyon içinden çağır
    birArttırİçFonksiyon()

// Fonksiyonu çağır
birArttır 2


// Öz yinelemeli fonksiyon tanımlamak için "rec" anahtar kelimesi kullanılır
// Aşağıdaki fonksiyon öz yinelemeli olarak faktöriyel hesabı yapar
let rec fact x = 
    if x <= 1 then 1 else x * fact (x - 1)

// F#'da fonksiyonların dönüş değerleri dolayılı olarak belirlenir bu nedenle 
// "return" benzeri bir anahtar kelimeye ihtiyaç yoktur
// Bir fonksiyon bloğundaki son ifade her zaman dönüş değerini oluşturur

// ======== Desen Eşleme (Pattern Matching) ========
// Desen eşleştirme için Match..with.. yapısı kullanılır
let basitDesenEşleme =
   let x = 1
   match x with
    | 1 -> printfn "x'in değer 1"
    | 2 -> printfn "x'in değeri 2"
    // _ simgesi herhangi bir değeri eşlemek için yer tutucu olarak kullanılır
    | _ -> printfn "x'in değeri 1 veya 2 değil"   

// Some(..) ve None C benzeri dillerde null veya 
// Pascal benzeri dillerde nil olarak ifade edilen değeri de alabilen değer ifadelerini
// tanımlamak için kullanılır. F#'da Some/None dil yapısına option (opsiyon) denir
let geçerliDeğer = Some(42)
let geçersizDeğer = None

// In this example, match..with matches the "Some" and the "None",
// and also unpacks the value in the "Some" at the same time.
let optionKullanarakEşleme girdi =
   match girdi with
    | Some i -> printfn "Girdi değeri = %d" i
    | None -> printfn "Girdi değer belirtilmemiş"

// Ekrana "Girdi değeri = 42" basılacak
optionKullanarakEşleme geçerliDeğer

// Ekrana "Girdi değer belirtilmemiş" basılacak
optionKullanarakEşleme geçersizDeğer

// ========= Karmaşık Veri Tipleri  =========

// Değer grupları (tuple) farklı tiplerde değer barındırabilen tiplerdir. 
// Değer grubu tanımlanırken virgül kullanılır
let ikili = 1,2
let üçlü = "a",2,true

// Kayıt tiplerinin alanları vardır ve alanları ayrımak için noktalı virgül kullanılır
type Öğrenci = {Ad:string; Soyad:string; Numara:int}
let öğrenci1 = {Ad="Arda"; Soyad="Özgür";Numara=124}

// Bileşimler (union) birden fazla seçenek tanımlamamızı sağlar. 
// Bunlara ayrışımlı bileşimler (discriminated union) de denir
// Bileşimlerin seçenkleri dikine çizgi (|) simgesi ile birbirinden ayrışırlar
type Derece = 
	| C of float
	| F of float
let dereceSantigrad = C 20.0
let dereceFahrenheit = F 68.0

type Kişi = {Ad:string;Soyad:string}
// Tipler öz yinelemeli olarak karmaşık yapılar (örneğin ağaç yapısı) 
// oluşturacak şekilde tanımlanabilir.
// Aşağıdaki örnekte İşçi ve Yönetici'den oluşan ve 
// Yönetici olarak öz yinelemeli bir şekilde Çalışan listesi kullanan 
// basit bir ağaç tanımı yapılıyor
type Çalışan = 
  | İşçi of Kişi
  | Yönetici of Çalışan list

let kişi = {Kişi.Ad="Ali";Soyad="Özgür"}
let işçi = İşçi kişi

// ========= Ekrana çıktı gönderme =========
// F# standard kütüphanesindeki printf/printfn fonksiyonları 
// ekrana metin basmak için kullanılır
printfn "Bir int %i, bir float %f ve bir bool %b" 42 3.14 true
printfn "Metin %s ve tipi ile ilgilinemiyorum : %A" "Merhaba Dünya" [1;2;3;4;5]

// F# tüm karmaşık tipleri ekrana düzgün formatlayarak basar
printfn "ikili=%A,\nkişi=%A,\nişçi=%A"  ikili kişi işçi

// Formatlanmış metni çıktı olarak döndürürmek için 
// F# standard kütüphanesindeki sprintf fonksiyonun kullanabilirsiniz
let çıktı1 = sprintf "Bir int %i, bir float %f ve bir bool %b" 42 3.14 true
let çıktı2 = sprintf "Metin %s ve tipi ile ilgilinemiyorum : %A" "Merhaba Dünya" [1;2;3;4;5]
let çıktı3 = sprintf "ikili=%A,\nkişi=%A,\nişçi=%A"  ikili kişi işçi
