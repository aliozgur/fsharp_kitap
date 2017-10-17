(* 08_3_02.fsx *)
let kare (x:int) = x * x

let topla (x: int list) = 
    List.sum x

let liste = [1;2;3;4]

let kareler = List.map kare liste
topla kareler

topla (List.map kare liste)

liste |> List.map kare |> topla

topla <| List.map kare liste

let üçSayıyıTopla x y z= 
    printfn "x = %d, y = %d, z = %d" x y z
    x + y + z

12 |> üçSayıyıTopla 4 5 
//x = 4, y = 5, z = 12
//val üçSayıyıTopla : x:int -> y:int -> z:int -> int
//val it : int = 21
