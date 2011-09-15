#light
module ProjectEuler.Problem2

open System

let fibs =
    Seq.unfold (fun (n0, n1) -> Some(n0, (n1, n0 + n1))) (1I, 1I)
        |> Seq.takeWhile(fun n -> n < 4000000I)
        |> Seq.filter(fun n -> n % 2I = 0I)
        |> Seq.sum

let run = printfn "Answer: %A" fibs