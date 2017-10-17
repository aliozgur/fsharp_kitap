(* 06_1_03.fsx *)

// √a
let KareköküOlanlarıVer (liste : int list) = 
    liste 
    |> List.map ( fun x -> float(x))
    |> List.filter ( fun x -> sqrt(x) % 1.0 = 0.0 )
    |> List.map ( fun x -> int(x))

//∜a
let DördüncüDereceKöküOlanlarıVer (liste : int list) = 
    liste 
    |> List.map ( fun x -> float(x))
    |> List.filter ( fun x -> System.Math.Pow(x, 1.0/4.0) % 1.0 = 0.0 )
    |> List.map ( fun x -> int(x))


// TEST
// İlk test
KareköküOlanlarıVer [1;2;3;4;6;7;9;10;12;15;16]
// Sonuç [1; 4; 9; 16]
DördüncüDereceKöküOlanlarıVer [1;2;3;4;6;7;9;10;12;15;16]
// Sonuç [1; 16]

// İkinci test
let girdi = [1;2;3;4;6;7;9;10;12;15;16]
KareköküOlanlarıVer girdi
// Sonuç [1; 4; 9; 16]
DördüncüDereceKöküOlanlarıVer girdi
// Sonuç [1; 16]
