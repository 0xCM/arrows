namespace models

module Say =
    let hello name =
        printfn "Hello %s" name

type Person = {
    name:string
    address:string
    }

type Box = {
    left:int
    top:int
    right: int
    bottom: int
}

