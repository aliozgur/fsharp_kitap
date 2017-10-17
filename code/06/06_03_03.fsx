(* 06_03_03.fsx *)

// ------ mutable ile yığında değişken tanımlama ------
let mutable x = 42
let mutable y = x

printfn "İlk değerler; x = %d ve y = %d" x y
// Çıktı : İlk değerler; x = 42 ve y = 42


y <- 1001
printfn "Yeni değerler; x = %d ve y = %d" x y
// Çıktı : Yeni değerler; x = 42 ve y = 1001


// ------ ref<'a> ile öbekte değişken tanımlama ------

let k: ref<int> = ref 42
let m: ref<int> = k

printfn "İlk değerler; k = %d ve m = %d" !k !m
// Çıktı : İlk değerler; k = 42 ve m = 42


m := 1001
printfn "Yeni değerler; x = %d ve y = %d" !k !m
// Çıktı : Yeni değerler; k = 1001 ve m= 1001

