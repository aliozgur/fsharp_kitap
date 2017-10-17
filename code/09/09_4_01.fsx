(* 09_4_01.fsx *)

open System.Threading
open System.Threading.Tasks
open System.IO

let dizi = Array.init 100 (id) 

let elemanıYazdır i = 
    Thread.Sleep(10)
    printfn "Değer %d" dizi.[i]

#time "on"
for i in 1..99 do
    elemanıYazdır i

#time "off"

#time "on"
Parallel.For(0,dizi.Length,elemanıYazdır)
#time "off"

let elemanıYazdır' değer = 
    Thread.Sleep(10)
    printfn "Değer %d" değer


#time "on"
Parallel.ForEach(dizi,elemanıYazdır')
#time "off"