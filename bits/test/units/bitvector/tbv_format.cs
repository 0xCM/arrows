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


    public class tbv_format : BitVectorTest<tbv_format>
    {

        public void format16()
        {
            var p1 = GfPoly.Gfp_8_4_3_2_0;
            var p2 = GfPoly16.FromExponents(8,4,3,2,0);
            var p3 = GfPoly16.FromScalar(0b100011101);

            Claim.eq(p3.Degree,(byte)8);                        
            Claim.eq(p1.Scalar, p2.Scalar);
            Claim.eq(p1.Format(),p2.Format());                
        }
    }

}