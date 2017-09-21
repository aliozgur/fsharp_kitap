(* 02_1_01.fs *)
[<EntryPoint>]
let main args = 
    
    // Ekrana yaz
    printfn "Merhaba Dünya!"
    
    // Uygulama parametrelerinin hepsini sırasıyla ekrana bas
    args |> Array.iter( fun s -> printfn "Merhaba %s." s)
    
    printfn "-------"
    printfn "Sonlandırmak için lütfen ENTER'a basın."
    let l = System.Console.ReadLine()

    0