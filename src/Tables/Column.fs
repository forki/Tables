namespace Tables

open Utilities

module Column =
    let Col (f: 'input -> 'value) :Column<'input, 'style> =
        {
            Header = None
            Value = f >> box
            Type = typeof<'value>
            Style = None
        }
    
    let ComputeCell (x: 'input) (col: Column<'input, 'style>) :Cell<'style> option=
        let cell =
            {
                Cell.Value = col.Value x
                Type = col.Type
                Style = (Option.apply col.Style) (Some x)
            }
        Some cell

    let WithStyle (s: 'input -> 'style) (c: Column<'input, 'style>) :Column<'input, 'style> =
        {c with Style = Some s}

    let WithHeader (h: Cell<'style>) (c: Column<'input, 'style>) :Column<'input, 'style> =
        {c with Header = Some h}
    
    let WithHeaderStyle (s: 'style) (c: Column<'input, 'style>) :Column<'input, 'style> =
        let newHeader =
            match c.Header with
            | Some h -> {h with Style=Some s}
            | None ->
            Cell.toCell ""
            |> Cell.WithStyle s
        {c with Header = Some newHeader}

    let Empty<'input, 'style> :Column<'input, 'style> = Col (fun _ -> "")




    let toTable (cols: Column<'input, 'style> list) (input: 'input list) :Table<'style> =
        let colsArray = Array.ofList cols
        let inputArray = Array.ofList input
        let computeCell i j = ComputeCell inputArray.[i] colsArray.[j]
        Array2D.init input.Length cols.Length computeCell