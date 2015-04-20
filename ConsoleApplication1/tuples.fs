namespace FSharpPlayground
open System.Drawing
  
module tuples=

//    let tuple = 5, 7, "dummy"
//
//    let zeug  a = match a with
//                  | ("b", a, true) when a = "b"  -> "c"
//                  | ("a", a, false) when a = "b"  -> "b"
//                  |  ("b", _, _) -> "c"
//                  | _ -> "Nix"
  
    let t = using (new Bitmap(10,10))(fun image -> (image.Width, image.Height))  
    
    printfn "Dim: %i mal %i" (fst t) (snd t)
