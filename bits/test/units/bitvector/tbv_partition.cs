//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;


    public class tbv_partition : UnitTest<tbv_partition>
    {
        public void bvpart_32x16()
        {
            Span<BitVector16> dst = stackalloc BitVector16[2];
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitVector32();
                bitvector.partition(x, dst);
                Claim.eq(dst[0], x.Lo);
                Claim.eq(dst[1], x.Hi);
            }
        }
    }
}
