(* 06_7_03.fsx *)

do invalidArg "argüman-adı" "Argüman değeri geçersiz!"
(*
System.ArgumentException: Argüman değeri geçersiz!
Parameter name: argüman-adı
*)

do nullArg "argüman-adı"
(*
System.ArgumentNullException: Value cannot be null.
Parameter name: argüman-adı!
*)

do invalidOp "Geçersiz işlem!"
(*
System.InvalidOperationException: Geçersiz işlem!
*)