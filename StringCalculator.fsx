let add numbers =
    match numbers with
    | "" -> 0
    | _ -> 
     let arrayNumbers = 
         numbers.Split(',')
         |> Array.map (fun x -> 
             match System.Int32.TryParse(x) with
             | (true, value) -> value 
             | (false, _) -> 0)     
     arrayNumbers |> Array.sum