#light
module ProjectEuler.Problem1

open System

let private answers =
    [1 .. 999]|>Seq.fold( fun sum x ->
        if x % 3 = 0 || x % 5 = 0 then
            sum + x
            else sum) 0

let run = printfn "Answer: %d" answers