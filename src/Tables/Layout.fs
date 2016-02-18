namespace Tables


module Layout =
    
    let private blitTo (source: 'a[,]) (target: 'a[,]) (targetIndex1: int) (targetIndex2: int) :unit =
        Array2D.blit source 0 0 target targetIndex1 targetIndex2 (Array2D.length1 source) (Array2D.length2 source)

    
    //let Place (x: Table<'style>) (y: Table<'style>) 

    let Horizontal (left: Table<'style>) (right: Table<'style>) =
        let outRows =
            [left; right]
            |> List.map Array2D.length1
            |> List.max
        let outCols =
            [left; right]
            |> List.map Array2D.length2
            |> List.sum
        let out :Table<'style> = Array2D.zeroCreate outRows outCols
        blitTo left out 0 0
        blitTo right out 0 (Array2D.length2 left)
        out

    let Vertical (top: Table<'style>) (bottom: Table<'style>) =
        let outRows =
            [top; bottom]
            |> List.map Array2D.length1
            |> List.sum
        let outCols =
            [top; bottom]
            |> List.map Array2D.length2
            |> List.max
        let out :Table<'style> = Array2D.zeroCreate outRows outCols
        blitTo top out 0 0
        blitTo bottom out (Array2D.length1 top) 0
        out

    let Array2D (tabs: Table<'style>[,]) =
        let rowNums = [|0..((Array2D.length1 tabs)-1)|]
        let rows = Array.map (fun n -> tabs.[n, 0..]) rowNums
        rows
        |> Array.map (Array.reduce Horizontal)
        |> Array.reduce Vertical