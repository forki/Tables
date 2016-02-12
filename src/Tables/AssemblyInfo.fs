namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Tables")>]
[<assembly: AssemblyProductAttribute("Tables")>]
[<assembly: AssemblyDescriptionAttribute("Tools for simple table specification")>]
[<assembly: AssemblyVersionAttribute("0.0.1")>]
[<assembly: AssemblyFileVersionAttribute("0.0.1")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.1"
