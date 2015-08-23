let input = [ (1., 2., 0.); (2., 1., 1.); (3., 0., 1.) ]
let rec search lst =
  match lst with
  | (1., _, z) :: tail -> printfn "found x=1. and z=%f" z; search tail
  | (2., _, _) :: tail -> printfn "found x=2."; search tail
  | _ :: tail -> search tail
  | [] -> printfn "done."
search input
