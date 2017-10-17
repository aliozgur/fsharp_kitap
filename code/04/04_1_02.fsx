(* 04_1_02.fsx *)

(*
        Tip-1 Desen Eşleme : Değere atama
*)
let birVarsaBirOlmayanaDeğerBul ((x,y):int*int)=
    match (x,y) with
    | (1,1) -> None
    | (1,a) -> Some(a)
    | (a,1) -> Some(a)
    | _ -> None

// TEST
birVarsaBirOlmayanaDeğerBul (1,4)
birVarsaBirOlmayanaDeğerBul (3,1)
birVarsaBirOlmayanaDeğerBul (3,4)
birVarsaBirOlmayanaDeğerBul (1,1)


let karşılaştır x y = 
    match (x,y) with
    | a,b when a > b -> printfn "%d > %d" a b
    | a,b when a < b -> printfn "%d < %d" a b
    | _ -> printfn "%d = %d" x y

// TEST
karşılaştır 1 2
karşılaştır 2 1
karşılaştır 1 1


(*
        Tip-2 Desen Eşleme: VE ve VEYA kombinasyon
*)
let değerlerdeBirVarMı x y = 
    match x,y with
    | (1,_) & (_,1) -> printfn "Değerlerden en az biri 1"
    | (1,_) | (_,1) -> printfn "Değerlerden en az biri 1"
    | _ -> printfn "Değerler arasında 1 yok"

// TEST
değerlerdeBirVarMı 1 2
değerlerdeBirVarMı 3 1
değerlerdeBirVarMı 4 4 
değerlerdeBirVarMı 1 1

(*
        Tip-3 Desen Eşleme : Listeler
*)

// ------ Eleman Sayılarına Göre ------
let listedeÜçElamanMıVar liste = 
    match liste with
    | [] -> printfn "Boş"
    | [_;b;_] -> printfn "Üç elemanlı,ikinci eleman %A" b
    | _ -> printfn "Üç eleman yok"

// TEST
listedeÜçElamanMıVar [1;2]
listedeÜçElamanMıVar []
listedeÜçElamanMıVar [4;5;6]
listedeÜçElamanMıVar [4;5;6;7]

// ------ :: ile baş ve kuyruğu eşleme -----
let listeyiParçala liste = 
    match liste with
    | [] -> printfn "Liste boş"
    | baş::kuyruk -> printfn "İlk elemanın %A geri kalanlar %A" baş kuyruk

// TEST
listeyiParçala []
listeyiParçala [1;2;3;4]

// ------ Öz yinelemeli fonksiyon  -----
let rec tekTekYazdır liste = 
    match liste with
    | [] -> printfn ""
    | baş::kuyruk -> 
                    printfn "%A" baş
                    tekTekYazdır kuyruk

// TEST
tekTekYazdır [1;2;3;4]
tekTekYazdır []

(*
        Tip-4 Desen Eşleme : Kayıt ve Ayrışık Bileşimler
*)

// SayıVeyaMetin isimli ayrışık bileşim
type SayıVeyaMetin = 
    | S of int // Sayı
    | M of string // Metin

let sayıMıMetinMi (x:SayıVeyaMetin) = 
    match x with
    | S sayı -> printfn "Bu bir sayı ve değeri %d" sayı
    | M metin -> printfn "Bu bir metin ve değeri %s" metin

sayıMıMetinMi (S 42)
sayıMıMetinMi (M "Mahmut")


// Kişi isimli kayıt tipi
type Kişi = {Ad:string;Soyad:string;Data:SayıVeyaMetin}
let özgürleriVeAlileriTanımla kişi = 
    match kişi with
    | {Ad=ad;Soyad="Özgür";Data = S sayı} -> printfn "Bildim seni Özgür,%s.  Sayın = %d" ad sayı   
    | {Ad=ad;Soyad="Özgür";Data = M metin} -> printfn "Bildim seni Özgür,%s.  Metnin = %s" ad metin   
    | {Ad="Ali";Soyad=soyad;Data=data} -> printfn "Bildim seni Ali %s. Datan = %A " soyad data  
    | _ -> printfn "%s %s, seni çıkaramadım! Datan = %A" kişi.Ad kişi.Soyad kişi.Data

// TEST
özgürleriVeAlileriTanımla {Ad="Ali";Soyad="Şen";Data=M "Fenerbahçe"}
özgürleriVeAlileriTanımla {Ad="Arda";Soyad="Özgür"; Data= S 10}
özgürleriVeAlileriTanımla {Ad="Ali";Soyad="Özgür"; Data= M "F# ne güzel"}
özgürleriVeAlileriTanımla {Ad="Mahmut";Soyad="Tuncer";Data=M "Şeker,Un ve Yağ"}


(*
        Tip-5 Desen Eşleme : Parçalar ile brilikte değeri de ata
*)

let özgürFamilyasındanMı kişi = 
    match kişi with 
    | {Ad=a;Soyad="Özgür";Data=d} as k -> printfn "Ad=%s, Data = %A. Kişi %A" a d k
    | yabancı -> printfn "Seni çıkaramadım! %A" yabancı

// TEST
özgürFamilyasındanMı {Ad="Ali";Soyad="Özgür"; Data= M "F# ne güzel"}
özgürFamilyasındanMı {Ad="Arda";Soyad="Özgür"; Data= S 10}
