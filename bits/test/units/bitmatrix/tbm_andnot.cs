//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;



    public class tbm_andnot : UnitTest<tbm_andnot>
    {
        public void AndNot8()
        {
            var lhs = Polyrand.BitMatrix8();
            var rhs = lhs.Replicate();
            Claim.yea(lhs.AndNot(rhs).IsZero());
        }

        public void AndNot16()
        {
            var lhs = Polyrand.BitMatrix16();
            var rhs = lhs.Replicate();
            Claim.yea(lhs.AndNot(rhs).IsZero());
        }

        public void AndNot32()
        {
            var lhs = Polyrand.BitMatrix32();
            var rhs = lhs.Replicate();
            Claim.yea(lhs.AndNot(rhs).IsZero());
        }

        public void AndNot64()
        {
            var lhs = Polyrand.BitMatrix64();
            var rhs = lhs.Replicate();
            Claim.yea(lhs.AndNot(rhs).IsZero());
        }


    }

}