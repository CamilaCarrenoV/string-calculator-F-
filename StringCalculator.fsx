let add numbers =
    match numbers with
    | "" -> 0
    | _ when numbers.StartsWith("//") ->
        let delimiterEndIndex = numbers.IndexOf('\n')
        let customDelimiter = numbers.Substring(2, delimiterEndIndex - 2)
        let numbersPart = numbers.Substring(delimiterEndIndex + 1)
        let arrayNumbers = 
            numbersPart.Split([| customDelimiter.[0]; ','; '\n' |])
            |> Array.map (fun x -> 
                match System.Int32.TryParse(x) with
                | (true, value) -> value 
                | (false, _) -> 0)

        let negatives = arrayNumbers |> Array.filter (fun x -> x < 0)
        if negatives.Length > 0 then
            failwithf "Negatives not allowed: %A" negatives

        arrayNumbers |> Array.sum

    | _ -> 
        let arrayNumbers = 
            numbers.Split([| ','; '\n' |])
            |> Array.map (fun x -> 
                match System.Int32.TryParse(x) with
                | (true, value) -> value 
                | (false, _) -> 0)

        let negatives = arrayNumbers |> Array.filter (fun x -> x < 0)
        if negatives.Length > 0 then
            failwithf "Negatives not allowed: %A" negatives
        
        arrayNumbers |> Array.sum
