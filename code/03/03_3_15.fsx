(* 03_3_15.fsx *)

// Biriktirici Yöntemi 
// n! = n * (n-1) * (n-2) * .... * 1
let faktöriyel n = 
    let rec _faktöriyel n bakiye = 
        if n <=1 then 
            bakiye
        else 
            _faktöriyel (n-1) (n*bakiye)
    _faktöriyel n 1

// TEST : 6'nın faktöriyeli
faktöriyel 6

 
// TEST : 1 ile 10 arasındaki sayıların faktöriyeli
[1..10] |> List.iter ( fun x -> printfn "%d! = %d" x ( faktöriyel x))

(* 03_3_15.fsx *)

// Uzantıların Kullanımı 
// n! = n * (n-1) * (n-2) * .... * 1
let faktöriyel' n = 
    let rec _faktöriyel n f = 
        if n <=1 then 
            f()
        else 
            _faktöriyel (n-1) ( fun() -> n * f())
    _faktöriyel n ( fun() -> 1)

// TEST : 6'nın faktöriyeli
faktöriyel' 6

 
// TEST : 1 ile 10 arasındaki sayıların faktöriyeli
[1..10] |> List.iter ( fun x -> printfn "%d! = %d" x ( faktöriyel' x))