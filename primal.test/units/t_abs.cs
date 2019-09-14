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
        public void abs8i()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var src = Random.Next<sbyte>();
                Claim.eq(gmath.abs(src),Math.Abs(src));
            }
        }

        public void abs16i()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var src = Random.Next<short>();
                Claim.eq(gmath.abs(src),Math.Abs(src));
            }
        }

        public void abs32i()
        {

            for(var i=0; i<SampleSize; i++)
            {
                var src = Random.Next<int>();
                Claim.eq(gmath.abs(src),Math.Abs(src));
            }

        }

        public void abs64i()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var src = Random.Next<long>();
                Claim.eq(gmath.abs(src),Math.Abs(src));
            }

        }

    }

}