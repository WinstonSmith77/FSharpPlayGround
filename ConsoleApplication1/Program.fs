// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
namespace FSharpPlayground
module first=
    open System.Drawing
    open System
    open System.Text.RegularExpressions

    open ooStuff
     
    
    
    Greeter.Instance.SayHello()

  

   

    let private hexPattern =
        Regex("^#(?<color>[\dA-F]{8})$", RegexOptions.IgnoreCase ||| RegexOptions.Compiled)

    type Color with
        static member FromHex(hex) =
            match hexPattern.Match hex with
            | matches when matches.Success ->
             Color.FromArgb <| Convert.ToInt32(matches.Groups.["color"].Value, 16)
            | _ -> Color.Empty
            member x.ToHex() = sprintf "#%02X%02X%02X%02X" x.A x.R x.G x.B


    let order list sortFunc =
        List.sortBy sortFunc list

    let inline sortFunc x = x + x

    let dispose (obj:Bitmap) = obj.Dispose()

    [<EntryPoint>]
    let main argv = 
        let  a = [-10;2;4]
        let sorted = order a sortFunc
        printfn "%A" sorted

//    let  b = ["-10.0";"2.6";"4.7"]
//    let sorted2 = order b sortFunc
//    printfn "%A" sorted2
//
//    let  c = [-10.0;2.6;4.7]
//    let sorted3 = order c sortFunc
//    printfn "%A" sorted3

        use bitmap = new Bitmap(400,500)
   // dispose bitmap

        0 // return an integer exit code

