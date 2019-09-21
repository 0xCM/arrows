//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class tbv_reverse : BitVectorTest<tbv_reverse>
    {
        public void bb_reverse()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var bs = Random.BitString(n20);
                var block1 = bs.Replicate().ToBitBlock(n20);
                block1.Reverse();
                bs.Reverse();
                for(var j=0; j<bs.Length; j++)
                {
                    Claim.yea( bs[i] == block1[i]);
                }
            
                
            }
        }

    }

}