(* 06_7_04.fsx *)
open System.IO 


type HataBilgisi = {Mesaj:string;Kod:int}
exception TestException of HataBilgisi

// Kendi istisna tipimizden istisna fırlatma

do raise <| TestException {Mesaj="";Kod=1}

// Standard .NET kütüphanesindeki istisna tipinden 
// istisna fırlatma
do raise <| new FileNotFoundException("Dosya bulunamadı!","06_7_04.fs")
