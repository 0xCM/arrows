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
    
    public class t_fsm2 : UnitTest<t_fsm2>
    {


        public void run()
        {
            var machineCount = Pow2.T04;
            var spec1 = PrimalFsm.Specify<ushort>("Fsm2",750,750,100,120,Pow2.T15);
            var stats = PrimalFsm.Run(spec1, machineCount);
            var counts = stats.Select(x => x.ReceiptCount).ToArray();
            var count = math.sum(counts);
            inform($"A total of {count} events were processed");


        }
    }
}
