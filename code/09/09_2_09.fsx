(* 09_2_09.fsx *)

open System.Threading

// Beşyüzer bin eleman içerene ve eleman değerleri 1 olan listeler
let liste1 = List.init 500000 (fun _ -> 1)
let liste2 = List.init 500000 (fun _ -> 1)


use sinyal = new AutoResetEvent(false)

// Eleman değerleri toplamını içeren değişken
let mutable toplam = 0

// Theradlerin bitişine kadar beklemek için kullanılacak
let cd = new CountdownEvent(1)

// Arka planda yapılan toplama işlemi
// Parametre olarak geçilen listedeki
// eleman değerlerini toplam değişkenine
// ekle
let topla (liste:obj) = 
    let l = liste :?> (int list)   
    for i in l do 
        sinyal.WaitOne() |> ignore
        toplam <- toplam + i    
        sinyal.Set() |> ignore

    cd.Signal() |>ignore

// Threadlerimiz
let t1 = Thread(ParameterizedThreadStart topla)
let t2 = Thread(ParameterizedThreadStart topla)

// ilk threadi başlat ilk liste ile başlat
cd.AddCount()
t1.Start(liste1)

// ikinci theradi ikinci liste ile başlat
cd.AddCount()
t2.Start(liste2)

sinyal.Set()
cd.Signal()

// Theradlerin işlerini bitirmesini bekle
cd.Wait()

// toplam değerini terminale yazdır
printfn "Toplam = %d" toplam