(* 08_4_01.fsx *)

let f x = x * x

let g y = float y |> sin

let h x = 
    let m = f x
    g m

// TEST

h 2
// val it : float = -0.7568024953

g (f 2)
// val it : float = -0.7568024953


let birleştir f g x = g ( f x ) 

let h' x = birleştir f g x

// TEST
h' 2 // g (f 2) ile eş
// val it : float = -0.7568024953


let h' x = (>>) f g x
let h'' = f >> g 

// TEST
h' 2 // g (f 2) ile eş
h'' 2 // g (f 2) ile eş
// val it : float = -0.7568024953

let topla x y = x + y
let çarp x y = x * y

let ikiEkleÜçİleÇarp = topla 2 >> çarp 3

ikiEkleÜçİleÇarp 3