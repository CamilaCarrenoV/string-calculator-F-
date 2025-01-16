let add numbers =
    match numbers with
    | "" -> 0
    | _ -> 

    let arrayNumbers = numbers.Split(',')
    match arrayNumbers with
    | arr when arr.Length > 2 -> failwith "error"
    | _ -> 
        arrayNumbers
        |> Array.map (fun x -> 
            match System.Int32.TryParse(x) with
            | (true, value) -> value 
            | (false, _) -> 0)     
        |> Array.sum