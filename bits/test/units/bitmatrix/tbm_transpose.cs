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
        public void bm_transpose_12x14x16g()
        {
            bm_transpose_gn_check<N12,N14,short>();
        }

        public void bm_transpose_13x64x32g()
        {
            bm_transpose_gn_check<N13,N64,uint>();
        }

        public void bm_transpose_32x32x8g()
        {
            bm_transpose_gn_check<N32,N32,byte>();
        }

        public void bm_transpose_8x8x8g()
        {
            bm_transpose_gn_check<N8,N8,byte>();
        }

        public void bm_transpose_8x8x8()
        {
            var m1 = Random.BitMatrix8();
            var m2 = m1.Transpose();
            var m3 = m2.Transpose();            
            Claim.yea(m1 == m3);
        }


        public void bm_transpose_16x16x16()
        {
            var m1 = Random.BitMatrix16();
            var m2 = m1.Transpose();
            var m3 = m2.Transpose();
            Claim.yea(m3 == m1);
        }

        public void bm_transpose_32x32x32()
        {
            var m1 = Random.BitMatrix32();
            var m2 = m1.Transpose();
            var m3 = m2.Transpose();
            Claim.yea(m3 == m1);
        }

        public void bm_transpose_64x64x64()
        {
            var m1 = Random.BitMatrix64();
            var m2 = m1.Transpose();
            var m3 = m2.Transpose();
            Claim.yea(m3 == m1);    
        }

        public void bm_rowswap_32x32x32()
        {
            var m1 = Random.BitMatrix32();
            var m2 = m1.Replicate();

            m2.RowSwap(0,1);
            m2.RowSwap(1,2);
            m2.RowSwap(2,3);

            Claim.yea(m1.RowVector(0) == m2.RowVector(3));
        }

        void bm_transpose_gn_check<M,N,T>()
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            for(var sample = 0; sample <SampleSize; sample++)
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