open System

[<EntryPoint>]
let main argv =
    let rnd = new Random()

    let randomNumsInRange xs pickN = 
        xs
        |> List.mapi(fun i x -> rnd.Next(), x)
        |> List.sortBy(fun (r, _) -> r)
        |> List.map snd
        |> Seq.take (pickN)
        |> Seq.sort
        |> Seq.toArray

    let GenerateEuromillones = 
        (randomNumsInRange [1..50] 5, randomNumsInRange [1..12] 2)

    let GeneratePrimitiva = 
        randomNumsInRange[1..49] 6

    let GenerateGordoPrimitiva = 
        (randomNumsInRange [1..54] 5, randomNumsInRange [1..9] 1)

    GenerateEuromillones |> printfn "Euromillones: %A"
    GeneratePrimitiva |> printfn "Primitiva: %A"
    GenerateGordoPrimitiva |> printfn "Gordo de la primitiva: %A"

    0 // return an integer exit code
