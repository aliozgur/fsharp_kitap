(* 05_1_03.fsx *)

// Örnek Veri
type Kişi = {Ad:string;Soyad:string;Yaş:int}

let kişiler = [
    for i in 1..10 do
        yield {Ad=sprintf "Ad %d" i;Soyad=sprintf "Soyad %d" i;Yaş=i*10}
] 

let çocuklar = [
    for i in 1..10 do
        yield {Ad=sprintf "Çocuk Ad %d" i;Soyad=sprintf "Çocuk Soyad %d" i;Yaş=(i%2) + 1}
] 


let tamSayılar = [1..10]
let tamSayılar' = [1..5]
let ondalıkSayılar = [1.0..10.0]

// -------- List Modülü Fonksiyonları --------

// iter
kişiler 
    |> List.iter (fun k -> printfn "%s" k.Ad)

// iter2
List.iter2 (fun k s -> printfn "Yaş:%d, Tam Sayı:%d" k.Yaş s ) kişiler tamSayılar

// iteri
kişiler 
    |> List.iteri (fun i k -> printfn "%s, eleman pozisyonu %d" k.Ad i)

// iteri2
List.iteri2 (fun i k s -> printfn "Pozisyon: %d. Yaş:%d, Tam Sayı:%d" i k.Yaş s ) kişiler tamSayılar


// map
// Yaş alanının değerini bir azaltarak
// yeni kişi listesi oluştur
kişiler 
    |> List.map(fun kişi -> {kişi with Yaş=k.Yaş-1}) 

// Ad alanının değerlerinden oluşan
// yeni bir metin listesi oluştur
kişiler 
    |> List.map(fun kişi -> kişi.Ad)

// Ad ve Soyad alanlarının değerlerinden oluşan
// yeni bir değer grubu listesi oluştur
kişiler 
    |> List.map(fun kişi -> kişi.Ad,kişi.Soyad)


// İlk liste olan kişiler listesinin Kişi tipinden 
// elemanlarının Ad alnı değeri ile
// ikinci liste olan tamSayılar listesinin int tipinden
// elemanlarının değerinden oluşan string*int tipinden
// değer grubu listesi oluştur
List.map2 (fun kişi sayı -> kişi.Ad,sayı) kişiler tamSayılar

// Eleman pozisyon değeri ve Kişi'nin Ad alanı değerini
// içeren değer grubu listesi oluştur
kişiler 
    |> List.mapi(fun indeks kişi -> indeks,kişi.Ad)

// Eleman pozisyon değerini, Kişi'nin Ad alanı değerini ve
// tam sayı eleman değerini içeren değer grubu listesi oluştur
List.mapi2 (fun indeks kişi ssayı -> indeks,kişi.Ad,sayı) kişiler tamSayılar


// fold ile yaşların toplamı
List.fold (fun bakiye kişi -> kişi.Yaş + bakiye) 0 kişiler

// fold ile virgülle ayrılmış isimler metni
List.fold (fun bakiye kişi -> printfn "%s" kişi.Ad;string(kişi.Ad) + "," + bakiye) "" kişiler

// foldBack ile virgülle ayrılmış isimler metni
List.foldBack (fun kişi bakiye -> printfn "%s" kişi.Ad; string(kişi.Ad) + "," + bakiye) kişiler ""

List.fold2 (fun bakiye kişi sayı-> (kişi.Yaş*sayı) + bakiye) 0 kişiler tamSayılar

// reduce ile tam sayı dizi değerleri toplamı
List.reduce (fun bakiye sayı -> sayı + bakiye) tamSayılar

List.reduceBack (fun bakiye sayı -> sayı + bakiye) tamSayılar


List.scan (fun bakiye kişi -> printfn "%s" kişi.Ad;string(kişi.Ad) + "," + bakiye) "" kişiler

List.scanBack (fun kişi bakiye -> printfn "%s" kişi.Ad; string(kişi.Ad) + "," + bakiye) kişiler ""


ondalıkSayılar |> List.average

// Yaş alanının değerine göre ortalama hesapla
kişiler 
    |> List.averageBy( fun k -> float(k.Yaş))
    
ondalıkSayılar |> List.max

// Yaş alanının değerine göre en büyük değeri bul
kişiler 
    |> List.maxBy( fun k -> k.Yaş)

ondalıkSayılar |> List.min

// Yaş alanının değerine göre en küçük değeri bul
kişiler 
    |> List.minBy( fun k -> k.Yaş)
      
ondalıkSayılar |> List.sum

// Yaş alanının değerine göre en toplamı bul
kişiler 
    |> List.sumBy( fun k -> k.Yaş)

çocuklar
    |> List.countBy (fun k -> k.Yaş )


// Yaş'ı 45'den büyük eleman var mı
kişiler |> List.exists (fun k -> k.Yaş > 45)

// Yaş'ı 120'den büyük eleman var mı
kişiler |> List.exists (fun k -> k.Yaş > 120)

List.exists2 (fun k s -> k.Yaş > 45 && s < 10) kişiler tamSayılar


// Yaş'ı 45'den büyük ve Yaş'ı 80'den küçük elemanları filtrele
kişiler |> List.filter (fun k -> k.Yaş > 45 && k.Yaş < 80)

tamSayılar |> List.contains 10
kişiler |> List.contains {Ad="Ali";Soyad="Özgür";Yaş=38}

kişiler |> List.find (fun k -> k.Yaş > 45)
kişiler |> List.tryFind (fun k -> k.Yaş > 45)
kişiler |> List.tryFind (fun k -> k.Yaş > 120)


kişiler |> List.findIndex (fun k -> k.Yaş > 45)
kişiler |> List.tryFindIndex (fun k -> k.Yaş > 45)
kişiler |> List.tryFindIndex (fun k -> k.Yaş > 120)


kişiler |> List.forall (fun k -> k.Yaş > 0)
kişiler |> List.forall (fun k -> k.Yaş > 45)

List.forall2 (fun k s -> k.Yaş > 0 && s > 0) kişiler tamSayılar


tamSayılar |> List.sort
kişiler |> List.sort

(kişiler.[4..8] @ kişiler.[1..3])
    |> List.sortBy (fun k -> k.Ad)


(tamSayılar.[4..8] @ tamSayılar.[4..8]) 
    |> List.distinct

(kişiler.[4..8] @ kişiler.[4..8]) 
    |> List.distinct

