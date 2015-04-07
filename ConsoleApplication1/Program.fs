﻿// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

let order list sortFunc =
    List.sortBy sortFunc list

let inline sortFunc x =   x + x


[<EntryPoint>]
let main argv = 
    let  a = [-10;2;4]
    let sorted = order a sortFunc
    printfn "%A" sorted

    let  b = ["-10.0";"2.6";"4.7"]
    let sorted2 = order b sortFunc
    printfn "%A" sorted2

    let  c = [-10.0;2.6;4.7]
    let sorted3 = order c sortFunc
    printfn "%A" sorted3

    0 // return an integer exit code
