(* 06_7_06.fsx *)
let böl x y = 
    let sonuç = y / x
    printfn "İşlem bitti, temizlik vakti."

12 |> böl 2
// Çıktı : İşlem bitti, temizlik vakti. 

12 |> böl 0
// Çıktı : System.DivideByZeroException: Attempted to divide by zero. 


let böl' x y = 
    try
        y / x
    finally
        printfn "İşlem bitti, temizlik vakti."

12 |> böl' 2
// Çıktı:
// İşlem bitti, temizlik vakti.
// val it : int = 6


12 |> böl' 0
// Çıktı:
// İşlem bitti, temizlik vakti.
// System.DivideByZeroException: Attempted to divide by zero.
