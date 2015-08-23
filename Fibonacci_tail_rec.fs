let rec fib_tail_rec x y n =
  match n with
   | 0 -> x
   | n -> fib_tail_rec y (x + y) (n - 1)

let fib = fib_tail_rec 0 1 // currying

fib 9 |> printfn "fib(9)=%d"
fib 10 |> printfn "fib(10)=%d"
fib 11 |> printfn "fib(11)=%d"
