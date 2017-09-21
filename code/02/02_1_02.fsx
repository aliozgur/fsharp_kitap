(* 02_1_02.fsx *)

// Ekrana yaz
printfn "Merhaba Dünya!"

// Geçilen parametreleri sırasıyla ekrana bas
fsi.CommandLineArgs |> Array.iter( fun s -> printfn "Merhaba %A." s)

printfn "-------"
printfn "Sonlandırmak için lütfen ENTER'a basın."
let l = System.Console.ReadLine()
