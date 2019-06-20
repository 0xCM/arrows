//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;

    using static zfunc;

    using D = PrimalDelegates;

    public class NegateTest : UnitTest<AddTest>
    {
        public void UnsignedNegation()
        {
            var x1 = 128ul;
            var y1 = 18446744073709551488;
            var z1 = gmath.negate(x1);
            Claim.eq(y1,z1);            

            var x2 = 128u;
            var y2 = 4294967168u;
            var z2 = gmath.negate(x2);
            Claim.eq(y2,z2);            

            var x3 = (ushort)128;
            var y3 = (ushort)65408;
            var z3 = gmath.negate(x3);
            Claim.eq(y3,z3);            

            var x4 = (byte)128;
            var y4 = (byte)128;
            var z4 = gmath.negate(x4);
            Claim.eq(y4,z4);            

        }

    }


}