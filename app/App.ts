import {List,iter, Try, notify, error, inform} from "../libs/z0-core"

const run = () =>{
    var good = 0
    var bad = 0
        try
        {
            notify(inform(`win ${++good}`, `${name}`))
        }
        catch(oopsie)
        {
            notify(error(`fail ${++bad}`, `${name} - ${oopsie.toString()}`))
        }
    }

run()

const testtuple = ["abc", () => {}]
const testtuple1 = ["abc", 34]
