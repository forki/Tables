module Tables.Tests

open Tables
open Tables.Types
open Tables.Column

open NUnit
open NUnit.Framework
open FsUnit

(*
let data = [1.1; 2.3; 4.5]
let cols :Column<float, string> list =
    [
        Col (fun x -> 2.0*x)
            |> Column.WithStyle (fun _ -> "white")
        Column.Empty
        Col (fun x -> 0.1*x)
        Col (fun _ -> "Bob")
    ]
let t = Column.toTable cols data

let vals =
    t
    |> Array2D.map (Option.map (fun x -> x.Value))

let h = Layout.Horizontal t t;;
let hVals =
    h
    |> Array2D.map (Option.map (fun x -> x.Value))

[<Test>]
let ``simple specification works`` () =
    vals.[1,2] |> should (equalWithin 0.0001) 0.23

[<Test>]
let ``empty column works`` () =
    vals.[1,1] |> should equal ""
*)