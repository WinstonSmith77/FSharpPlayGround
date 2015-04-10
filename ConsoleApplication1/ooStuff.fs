namespace FSharpPlayground
module ooStuff=

 type IFirst =
        abstract F : unit -> unit
        abstract G : unit -> unit



 type Greeter private () =
        static let _instance = lazy (Greeter())
        static member Instance with get() = _instance.Force()
        member x.SayHello() = printfn "hello"   

