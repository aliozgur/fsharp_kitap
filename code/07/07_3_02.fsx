(* 07_3_02.fsx *)

type Dikdörtgen(x:int,y:int) = 
    
    member this.X = x
    member this.Y = y

    member this.DeğerGrubuÖrneği(a:int,b:int) = 
        printfn "a=%d, b=%d" a b

    member this.NormalParamÖrneği (a:int) (b:int) = 
        printfn "a=%d, b=%d" a b


// TEST

let d = Dikdörtgen(2,3)
d.DeğerGrubuÖrneği(42,1)
d.NormalParamÖrneği 42 1

// Kısmi uygulama yapılamaz
let KırkİkiVeBirSayıYazdı b = d.DeğerGrubuÖrneği(42,b)
KırkİkiVeBirSayıYazdır 12


// Kısmi uygulama yapılabilir
let KırkİkiVeBirSayıYazdır' = d.NormalParamÖrneği 42
KırkİkiVeBirSayıYazdır' 12
