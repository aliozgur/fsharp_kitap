(* 04_4_04.fsx *)
open System

// Tam sayılar için üye tanımları int tipi kullanılarak
// aşağıdaki gibi yapılamaz.
//type int with

type Int32 with  

    // Tip için tanımlanan static üyeler
    static member MetneÇevir x = sprintf "%d" x
    static member ÇiftMi x = x % 2 = 0
    static member EvreninSırrı = 42
    
    // Değer için tanımlı üyeler
    member this.EvreninSırrınıEkle = this + Int32.EvreninSırrı

// TEST
// Static üyeler
Int32.MetneÇevir 12
Int32.ÇiftMi 3
Int32.EvreninSırrı

// Değer için üye
(1).EvreninSırrınıEkle