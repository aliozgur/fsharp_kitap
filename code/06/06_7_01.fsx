(* 06_7_01.fsx *)

exception İstisna1Exception of string
exception İstisna2Exception of string * int

type HataBilgisi = {Mesaj:string;Kod:int}

exception İstisna3Exception of HataBilgisi

let istisnaFırlat istisnaNo = 
    match istisnaNo with
    | 1 -> raise <| İstisna1Exception "İstisna 1"
    | 2 -> raise <| İstisna2Exception ("İstisna 2", 2)
    | 3 -> raise <| İstisna3Exception {Mesaj="İstisna 3"; Kod=3}
    | _ -> ()

istisnaFırlat 1
istisnaFırlat 2
istisnaFırlat 3