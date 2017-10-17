(* 05_3_01.fsx *)

open System
(*
// OutOfMemoryException

let liste = [
    for i in Int64.MinValue..Int64.MaxValue do 
        yield i
]

let dizi = [|
    for i in Int64.MinValue..Int64.MaxValue do 
        yield i
|]
*)

let s1 = seq{1..10}

let s2 = seq{1..2..10}

let s3 = seq{
    for i in 1..10 do
        yield i        
}

let s4 = seq<string>{
    for i in 1..10 do
        yield sprintf "Değer :%d" i        
}

