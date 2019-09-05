//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rng.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    using static zfunc;

    
    public class t_bitstring : UnitTest<t_bitstring>
    {

        public void distribution()
        {
            const int len = 16*16;
            var samples = Pow2.T16;
            var stats = new Accumulator();
            var src = Random.BitStrings(len);
            for(var i=0; i< samples; i++)
                stats.Accumulate(src.First().PopCount());

            var ideal = len/2.0;
            var actual = stats.Mean;
            var delta = math.abs(actual - ideal).Round(6);
            Claim.yea(delta < .01);
            
        }
    }

}