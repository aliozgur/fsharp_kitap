(* 03_3_10.fsx *)

(*
    List.map fonksiyonun imzası şöyledir;
    val it : (('a -> 'b) -> 'a list -> 'b list)
    Bu fonksiyon ilk parametre olarak bir fonksiyon ikinci parametre olarak
    ise bir liste alır
*)

// "küp" fonksiyonumuz
let küp x = x * x * x

// test listemiz 1 ile 10 arasındaki değerleri barındırır
let liste = [1..10]

// List.map fonksiyonun normal kullanımı
List.map küp liste

// List.map fonksiyonun ileri akatrım operatörü ile kullanımı
liste |> List.map küp

// List.map fonksiyonunndan faydalanan hepsininKüpünüAl isimli
// yeni bir fonksiyonu List.map'i kısmi uygulayarak oluşturuyoruz
// Kısmi uygulamada List.map fonksiyonu için ilk parametreyi "küp"
// fonksiyonu olacak şekilde sabitledik ikinci parametre belirtilmedi

let hepsininKüpünüAl = List.map küp

//Türettiğimiz hepsininKüpünüAl fonksiyonun imzası şöyledir
// "val hepsininKüpünüAl : (int list -> int list)"

// Bu yeni fonksiyon bir int listesi alır ve 
// sonuç olarak bir int listesi döner
hepsininKüpünüAl liste

// İleri aktarım operatörü ile çağırıyoruz 
liste |> hepsininKüpünüAl