(* 10_1_01.fsx *)

type Monad<'T> = {
    Value:'T
} with 
    static member Return value = {Value=value}  
    member this.Bind (func:'a -> Monad<'b>): Monad<'b> = func this.Value


type Maybe<'a>=
    | Just of 'a
    | Nothing
with
    static member Return (x: 'a) : Maybe<'a> =
        Just(x)

    member this.Bind (f: 'a -> Maybe<'b>) : Maybe<'b> =
        match this with
        | Just(x) -> f x
        | Nothing -> Nothing