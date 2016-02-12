namespace Tables


module Utilities =

    type Microsoft.FSharp.Core.Option<'o> with
        static member apply (f: ('a -> 'b) option) : ('a option -> 'b option) =
            match f with
            | Some g -> Option.map g
            | None -> (fun _ -> None)
