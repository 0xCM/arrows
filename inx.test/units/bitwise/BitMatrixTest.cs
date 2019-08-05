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
    #pragma warning disable 1718

    public class BitMatrixTest : UnitTest<BitMatrixTest>
    {




        public void Eq32()
        {
            var x = Random.BitMatrix32();
            var y = Random.BitMatrix32();
            Claim.nea(x.Equals(y));
            Claim.yea(x.Equals(x));
            Claim.yea(y.Equals(y));
        }

        public void Eq64()
        {
            var x = Random.BitMatrix64();
            var y = Random.BitMatrix64();
            Claim.nea(x.Equals(y));
            Claim.nea(x == y);
            Claim.yea(x != y);

            Claim.yea(x.Equals(x));
            Claim.yea(x == x);

            Claim.yea(y.Equals(y));
            Claim.yea(y == y);
        }

        public void Flip64()
        {
            
            var x = Random.BitMatrix64();
            var y = x.Replicate();
            var xff = ~(~x);
            Claim.yea(xff == y);

            var c = Random.BitMatrix64();
            var a = span<ulong>(64);
            for(var i = 0; i<64; i++)
                a[i] = ~ c.Row(i);
            var b = BitMatrix64.Define(a);
            Claim.yea(b == ~c);        
        }

        void VerifyExtract<M,N,T>(BitMatrix<M,N,T> src)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
        {
            for(var row=0; row< src.RowCount; row++)
            {
                var vector = src.Row(row);
                for(var col=0; col<vector.Length; col++)
                    Claim.eq(vector[col], src[row,col]);
            }

        }

        public void VectorExtract()
        {
            VerifyExtract(Random.BitMatrix<N9,N9,byte>());
            VerifyExtract(Random.BitMatrix<N9,N9,ushort>());
            VerifyExtract(Random.BitMatrix<N128,N128,uint>());
            VerifyExtract(Random.BitMatrix<N16,N128,uint>());
            VerifyExtract(Random.BitMatrix<N5,N7,uint>());            
        }
        
        public void ColumnExtract16()
        {
            var m = Random.BitMatrix16();
            var c = m.Col(3);
            for(var i=0; i<16; i++)
                Claim.eq(c[i], m[i,3]);
        }


        public void ColumnExtract64()
        {
            for(var j = 0; j< Pow2.T14; j++)
            {
                var m = Random.BitMatrix64();
                var colidx = 13;
                var c = m.Col(colidx);
                for(var i=0; i<m.RowDim; i++)
                    Claim.eq(c[i], m[i,colidx]);
            }
        }


    }


}