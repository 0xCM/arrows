//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;

    using static zfunc;

    public class t_abs : UnitTest<t_abs>
    {

        public void abs64f()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var src = Random.Next<double>();
                Claim.eq(src < 0 ? -src : src, gmath.abs(src));
                Claim.eq(gmath.abs(src), cephes.fabs(src));
            }

        }
    }

}