let küp x = x * x * x
let liste = [1..10]

//------ KISMİ UYGULAMA UYUMLU OLMAYAN YAKLAŞIM ------//
// Paremetreleri kısmi uygulama için uygun sıralanmamış
// map' fonksiyonu tanımı
// İlk parametre int değerler tutan liste
// Son parametre bir fonksiyon
let map'  (liste : 'a list) (f:'a->'b) : 'b list =    
    let sonuç = seq{for x in liste -> (f x)}
    sonuç |> List.ofSeq


// map' fonksiyonunu kullanarak bir listenin tüm değerlerinin
// küpünü alacak şekilde yeni bir fonksiyonu aşağıdaki gibi türetemiyoruz
// let hepsininKüpünüAl = map' küp

// map' fonksiyonun kullanarak ancak aşağıdaki gibi bir
// hepsininKüpünüAl fonksiyonu oluşturabiliriz
let hepsininKüpünüAl liste = map' liste küp

hepsininKüpünüAl liste
liste |> hepsininKüpünüAl

//------ KISMİ UYGULAMA UYUMLU YAKLAŞIM ------//

// Paremetreleri kısmi uygulama için uygun sıralanmış
// map'' fonksiyonu tanımı. 
// İlk parametre bir fonksiyon
// Son parametre int değerler tutan liste
let map''  (f:'a->'b) (liste : 'a list)  : 'b list =    
    let sonuç = seq{for x in liste -> (f x)}
    sonuç |> List.ofSeq

// map'' fonksiyonunu kullanarak bir listenin tüm değerlerinin
// küpünü alacak şekilde yeni bir fonksiyonu aşağıdaki gibi 
// türetebiliriz
let hepsininKüpünüAl' = map'' küp

hepsininKüpünüAl' liste
liste |> hepsininKüpünüAl'
