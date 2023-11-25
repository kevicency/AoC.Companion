module String

open System

let splitLines (input: String) =
  input.Split("\n")
  |> Array.map (fun (x: String) -> x.Trim())
  |> Array.filter (fun (x: String) -> x <> "")
