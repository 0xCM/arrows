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

    using static Nats;


    public class GfPolyTest : UnitTest<GfPolyTest>
    {


        void Verify<N,T>(GfPoly<N,T> p, BitString match)
            where N : ITypeNat, new()
            where T : struct
        {

            var bs = BitString.FromScalar(p.Scalar).Truncate(p.Degree + 1);
            Claim.eq(bs, match);  

        }

        public void Verify()
        {
            
            Verify(GfPoly.Lookup<N3,byte>(), BitString.Parse("1011"));
            
            Verify(GfPoly.Lookup<N8,ushort>(4), BitString.Parse("100011101"));
            Claim.eq((ushort)0b100011101, GfPoly.Lookup<N8,ushort>(4).Scalar);
            
            Verify(GfPoly.Lookup<N8,ushort>(5), BitString.Parse("100101011"));
            Verify(GfPoly.Lookup<N16,uint>(), BitString.Parse("10000001111011101"));
            
        }


    }

}