let rec fib x =
  match x with
    | x when x < 0 -> failwith "value must be greater than 0"
    | x when x < 2 -> x
    | x -> fib (x - 1) + fib (x - 2)

fib 9 |> printfn "fib(9)=%d"
fib 10 |> printfn "fib(10)=%d"
fib 11 |> printfn "fib(11)=%d"
