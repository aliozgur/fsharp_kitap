(* 06_4_01.fsx *)

// Alan adının aç
open System.Collections.Generic


// -------------- List<T> --------------

// List<int> tipinden liste oluştur
let liste = new List<int>()

// listeye toplu olarak eleman ekle
liste.AddRange([1;2;3;4])

// listeye eleman ekle
liste.Add(5)
liste.Add(6)

// listeden eleman çıkar
liste.Remove(5)

// İlk iki elelanı çıkar
liste.RemoveRange(0,2)

// İkinci elemanı listeden çıkar
liste.RemoveAt(1)

// Liste elemanına pozisyon ile erişim
liste.[0]

// Eleman pozisyonu ile varolan değeri güncelleme
liste.[1] <- -1

// for ile iterasyon
for değer in liste do
    printfn "Değer = %d" değer


// -------------- Dictionary<K,V> --------------

// Değer olarak kullanılan Öğrenci kayıt tipi
type Öğrenci = {Ad:string;Soyad:string;Numara:int}

let öğrenciler = new Dictionary<int,Öğrenci>()

let arda = {Ad="Arda";Soyad="Özgür";Numara=1001}
// Öğrenci ekle
öğrenciler.Add(1001,arda)
öğrenciler.Add(1002,{Ad="Kuzey";Soyad="...";Numara=1002})

// Anahtarı içeriyor mu?
öğrenciler.ContainsKey(1001)
öğrenciler.ContainsKey(1001)

// Değeri içeriyor mu?
öğrenciler.ContainsValue(arda)

// Anahtar ile değere erişim
öğrenciler.[1001]

// Anahtar ile varolan değeri güncelleme
öğrenciler.[1002] <- {Ad="Sarp";Soyad="Oyuktaş";Numara=1002}

// Anahtar ile yeni değer ekleme
öğrenciler.[1003] <- {Ad="Mert";Soyad="...";Numara=1003}

// Anahtar ile değer silme
öğrenciler.Remove(1001)

// for ile iterasyon
for abahtarDeğerİkilisi in öğrenciler do
    printfn "Anahtar = %d, Değer = %A" 
            (abahtarDeğerİkilisi.Key) 
            (abahtarDeğerİkilisi.Value)

// -------------- HashSet<T> --------------

// HashSet<string> oluştur
let webAdresleri = new HashSet<string>()

// Değer ekle
webAdresleri.Add("aliozgur.net")
webAdresleri.Add("microsoft.com")
webAdresleri.Add("google.com")

// Değer sil
webAdresleri.Remove("google.com")
webAdresleri.Remove("xyz.com")

let webAdresleri' = new HashSet<string>()
webAdresleri'.Add("aliozgur.net")

// Kapsar kontrolü
webAdresleri.IsSupersetOf(webAdresleri')
webAdresleri.IsProperSupersetOf(webAdresleri')

// Alt kümesi mi kontrolü
webAdresleri'.IsSubsetOf(webAdresleri)
webAdresleri'.IsProperSubsetOf(webAdresleri)

// Kesişim ve Bileşim. Bu işlemler ilk HashSet
// içeriğini değiştirir!!!
webAdresleri.IntersectWith(webAdresleri')
webAdresleri.UnionWith(webAdresleri')

