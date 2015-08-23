let rec fib_tail_rec x y n =
  match n with
   | 0 -> x
   | n -> fib_tail_rec y (x + y) (n - 1)

let fib = fib_tail_rec 0 1 // currying

let print tuple1 =
   match tuple1 with
    | (a, b) -> printfn "fib(%A)=%A" a b

[|9; 10; 11|]
  |> Array.map (fun x -> (x, fib x))
  |> Array.iter print
