//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines.Test
{        
    using System;
    using System.Linq;
    using System.Threading;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Z0.Test;

    using static zfunc;
    
    public class Fsm2Test : UnitTest<Fsm2Test>
    {

        public void Run()
        {
            var machineCount = Pow2.T10;
            var spec1 = new PrimalFsmSpec<byte>("Fsm2",128,128,10,20,Pow2.T15);
            var stats = spec1.Run(machineCount);
            var counts = stats.Select(x => x.ReceiptCount).ToArray();
            var count = math.sum(counts);
            inform($"A total of {count} events were processed");


        }
    }
}
