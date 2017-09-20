(* 03_3_12.fsx *)

// Fibonacci Sayısı 
// Fₙ = Fₙ₋₁ + Fₙ₋₂
let rec fibonacci n = 
    if n <= 1 then 
        n
    else 
        fibonacci (n-1) + fibonacci(n-2) 

// TEST : 4. fibonacci sayısının değeri
fibonacci 4

// TEST : 1 ile 10 arasındaki Fibonacci sayıları
[1..10] |> List.iter ( fun x -> printfn "%d. fibonaci sayısı = %d" x ( fibonacci x))


(* 03_3_12.fsx *)

// Faktöriyel Hesaplama
// n! = n * (n-1) * (n-2) * .... * 1
let rec factorial n = 
    if n < 1 then
        1
    else 
        n * factorial(n-1)

// TEST : 6'nın faktöriyeli
factorial 6
 
// TEST : 1 ile 10 arasındaki sayıların faktöriyeli
[1..10] |> List.iter ( fun x -> printfn "%d! = %d" x ( factorial x))

(*
// Sonlanma koşulu olmayan hatalı öz yinelemeli fonksiyon
let rec fibonacci' n = 
    fibonacci (n-1) + fibonacci(n-2) 

fibonacci' 2147483647 //En büyük işaretli 32-bit tam sayı 
*)