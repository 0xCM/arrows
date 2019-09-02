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
        public void abs8()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var src = Polyrand.Next<sbyte>();
                Claim.eq(gmath.abs(src),Math.Abs(src));
            }
        }

        public void abs16()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var src = Polyrand.Next<short>();
                Claim.eq(gmath.abs(src),Math.Abs(src));
            }
        }

        public void abs32()
        {

            for(var i=0; i<SampleSize; i++)
            {
                var src = Polyrand.Next<int>();
                Claim.eq(gmath.abs(src),Math.Abs(src));
            }

        }

        public void abs64()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var src = Polyrand.Next<long>();
                Claim.eq(gmath.abs(src),Math.Abs(src));
            }

        }
    }

}