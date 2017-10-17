(* 05_5_02.fsx *)

let k1 = set[1;2;3;4]
let k2 = set[1;2;3]
let k3 = set[1;2;3]
let k4 = set[5..10]


Set.intersect k1 k2
//[1;2;3]

Set.union k1 k2
//[1;2;3;4]

Set.difference k1 k2
//[4]

Set.isSubset k2 k1
// true

Set.isSubset k4 k1
// false

Set.isProperSubset k2 k1
// true

Set.isProperSubset k2 k3
//false

