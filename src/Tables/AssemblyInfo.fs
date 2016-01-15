namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Tables")>]
[<assembly: AssemblyProductAttribute("Tables")>]
[<assembly: AssemblyDescriptionAttribute("Tools for simple table specification")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
