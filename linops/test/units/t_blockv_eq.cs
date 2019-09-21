//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    public static class Util
    {
        public static void ClaimEqual<N,T>(BlockVector<N,T> x, BlockVector<N,T> y)
            where T : unmanaged
            where N : ITypeNat, new()
        {
            var len = (int)(new N().value);

            for(var i = 0; i< len; i++)
                Claim.eq(x[i], y[i]);

            var eq = Linear.eq(x, y);
            for(var i=0; i<len; i++)
                Claim.yea(eq[i]);            

        }
    }
    
    public class tlv_eq : UnitTest<tlv_eq>
    {

        public void tlv_eq_32x32()
        {
            for(var i = 0; i < SampleSize; i++)
            {
                var x = Random.Vector<N32,uint>();
                var y = x.Replicate();
                var r = x.Map(i => i + 1);
                var z = Random.Vector<N32,uint>();
                Claim.eq(x,y);
                Claim.neq(x,z);
                Claim.neq(x,r);
            }
        }

    }

}