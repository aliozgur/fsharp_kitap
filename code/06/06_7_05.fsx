(* 06_7_05.fsx *)

// 1)
// .NET istisnalarını :? ile yakalama
let böl1 x y =
  try
    Some( x / y )
  with
    | :? System.DivideByZeroException -> printfn "İstisna! Sıfıra bölüm mümkün değil"; None

böl1 100 0

// 2)
// .NET istisnalarını :? ile yakalama ve as ile istisna değerini sökme
let böl2 x y =
  try
    Some( x / y )
  with
    | :? System.DivideByZeroException as ex -> printfn "İstisna! %s " (ex.Message); None

böl2 100 0

// 3)
// istisna-değerini sök 
let böl3 x y=
  try
     Some(x / y)
  with
     | ex -> printfn "%s" (ex.ToString()); None

böl3 100 0

// 4)
// istisna-değerini sök ve when ile koşul kontrolü
let böl4 x y flag =
  try
     x / y
  with
     | ex when flag -> printfn "TRUE: %s" (ex.ToString()); 0
     | ex when not flag -> printfn "FALSE: %s" (ex.ToString()); 1

böl4 100 0 true


// 5)
type HataBilgisi = {Mesaj:string;Kod:int}
exception İstisna1Exception of string * int
exception İstisna2Exception of HataBilgisi

let istisnaFırlat istisnaNo kod = 
    match istisnaNo with
    | 1 -> raise <| İstisna1Exception ("İstisna 1",kod)
    | 2 -> raise <| İstisna2Exception {Mesaj="İstisna 2"; Kod=kod}
    | _ -> ()

// 5)
// F# istisna tipi ile eşleş ve istisna alan/argüman değerlerini sök
let istisnaYakala istisnaNo kod =
   try
    istisnaFırlat istisnaNo kod
   with
      | İstisna1Exception(mesaj,kod) -> printfn "İstisna 1:  %s %d" mesaj kod
      | İstisna2Exception {Mesaj=mesaj;Kod=kod} -> printfn "İstisna 2:  %s %d" mesaj kod

istisnaYakala 1 -100
istisnaYakala 2 -200
istisnaYakala 3 -300

