namespace Tables

module Cell =
    let toCell (value: 'a) :Cell<'style> =
        {
            Value = box value
            Type = typeof<'a>
            Style = None
        }

    let WithStyle (s: 'style) (c: Cell<'style>) :Cell<'style> =
        {c with Style=Some s}