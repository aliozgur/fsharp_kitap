(* 08_3_01.fsx *)

let f x y = 
    printfn "x = %d, y = %d" x y
    x + y

f 4 2
// x = 4, y = 2
// val it : int = 6

let f' x =
    let _f y = 
        printfn "x = %d, y = %d" x y
        x + y
    
    _f

let kf = f' 4
kf 2 
// x = 4, y = 2
// val it : int = 6

(f' 4) 2
// x = 4, y = 2
// val it : int = 6


f' 4 2
// x = 4, y = 2
// val it : int = 6


