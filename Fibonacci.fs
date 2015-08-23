let rec fib x =
  match x with
    | x when x < 0 -> failwith "value must be greater than 0"
    | x when x < 2 -> x
    | x -> fib (x - 1) + fib (x - 2)

let print tuple1 =
   match tuple1 with
    | (a, b) -> printfn "fib(%A)=%A" a b

[9; 10; 11]
  |> List.map (fun x -> (x, fib x))
  |> List.iter print
