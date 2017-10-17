(* 07_1_03.fsx *)

type Sınıf1 () =
    member this.SınıfOluştur() = 
        Sınıf2(),Sınıf3()

and Sınıf2 () = 
    member this.SınıfOluştur() = 
        Sınıf1(),Sınıf3()
and Sınıf3 () = 
    member this.SınıfOluştur() =
        Sınıf1(), Sınıf2()