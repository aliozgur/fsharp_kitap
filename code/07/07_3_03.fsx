(* 07_3_03.fsx *)

type Matematik() = 
    member this.Fibonacci x = 
 match x with
        | 0 | 1 -> 1
        | _ -> this.Fibonacci (x-1) + this.Fibonacci (x-2)

let m = Matematik()
m.Fibonacci 5
