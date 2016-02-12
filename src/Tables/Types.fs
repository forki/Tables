namespace Tables


[<AutoOpen>]
module Types =
    open System
    open System.Data
    
    

    type Cell<'style> = {
        Value: obj
        Type: System.Type
        Style: 'style option
    }

    type Table<'style> = Cell<'style> option[, ]

    type Column<'input, 'style> = {
        Header: Cell<'style> option
        Value: 'input -> obj
        Type: System.Type
        Style: ('input ->'style) option
    }

    
    
    
