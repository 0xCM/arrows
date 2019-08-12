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

    public class BitMatrixOpsTest : UnitTest<BitMatrixOpsTest>
    {
        void Transpose<M,N,T>(int count)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
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

        public void Transpose()
        {
            Transpose<N12,N14,short>(Pow2.T07);
            Transpose<N32,N32,byte>(Pow2.T07);
            Transpose<N8,N8,byte>(Pow2.T07);
        }

    }


}