(* 04_5_02.fsx*)

let ekranaYazdır (x:'a) (y:'b) (z:'a) = 
    printfn "x=%A, y=%A,z=%A" x y z 

// TEST
ekranaYazdır  42 "Evrenin sırrı" 1001
ekranaYazdır  42.0 "Evrenin sırrı" 1001.0

// HATALI 1. ve 3 parametre aynı tipten olmalı
// 1. parametre int 3. parametre ise float 
//ekranaYazdır  42 "Evrenin sırrı" 1001.0



