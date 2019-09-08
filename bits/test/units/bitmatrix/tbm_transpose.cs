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

    public class tbm_transpose : UnitTest<tbm_transpose>
    {
        public void transposeGn()
        {
            transposeGn_test<N12,N14,short>(Pow2.T07);
            transposeGn_test<N32,N32,byte>(Pow2.T07);
            transposeGn_test<N8,N8,byte>(Pow2.T07);
        }

        public void transpose8()
        {
            var m1 = Random.BitMatrix8();
            var m2 = m1.Transpose();
            var m3 = m2.Transpose();            
            Claim.yea(m1 == m3);
        }

        public void transpose16()
        {
            var m1 = Random.BitMatrix16();
            var m2 = m1.Transpose();
            var m3 = m2.Transpose();
            Claim.yea(m3 == m1);
        }

        public void transpose32()
        {
            var m1 = Random.BitMatrix32();
            var m2 = m1.Transpose();
            var m3 = m2.Transpose();
            Claim.yea(m3 == m1);
        }

        public void transpose64()
        {
            var m1 = Random.BitMatrix64();
            var m2 = m1.Transpose();
            var m3 = m2.Transpose();
            Claim.yea(m3 == m1);    
        }

        public void rowswap32()
        {
            var m1 = Random.BitMatrix32();
            var m2 = m1.Replicate();

            m2.RowSwap(0,1);
            m2.RowSwap(1,2);
            m2.RowSwap(2,3);

            Claim.yea(m1.RowVec(0) == m2.RowVec(3));
        }

        void transposeGn_test<M,N,T>(int count)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            for(var c = 0; c <count; c++)
            {
                var src = Random.BitMatrix<M, N,T>();
                var tSrc = src.Transpose();
                for(var i=0; i<tSrc.RowCount; i++)
                for(var j=0; j<tSrc.ColCount; j++)
                    Claim.eq(tSrc[i,j], src[j,i]);
            }
        }


    }
}