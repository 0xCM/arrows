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

    public class tbm_extract : UnitTest<tbm_extract>
    {
        public void VectorExtract()
        {
            check_extract(Polyrand.BitMatrix<N9,N9,byte>());
            check_extract(Polyrand.BitMatrix<N9,N9,ushort>());
            check_extract(Polyrand.BitMatrix<N128,N128,uint>());
            check_extract(Polyrand.BitMatrix<N16,N128,uint>());
            check_extract(Polyrand.BitMatrix<N5,N7,uint>());            
        }

        public void col8()
        {
            CycleColExtract8();
        }

        public void col16()
        {

            CycleColExtract16();

        }

        public void col32()
        {
            CycleColExtract32();
        }

        public void col64()
        {
            CycleColExtract64();
        }

        void check_extract<M,N,T>(BitMatrix<M,N,T> src)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
        {
            for(var row=0; row< src.RowCount; row++)
            {
                var vector = src.RowVector(row);
                for(var col=0; col<vector.Length; col++)
                    Claim.eq(vector[col], src[row,col]);
            }
        }
        
        void CycleColExtract64(int cycles = DefaltCycleCount)
        {
            for(var j = 0; j< cycles; j++)
            {
                var src = Polyrand.BitMatrix64();
                for(var c = 0; c < src.ColCount; c ++)
                {
                    var col = src.ColVector(c);
                    for(var r=0; r<src.RowCount; r++)
                        Claim.eq(col[r], src[r,c]);
                }
            }

        }

        void CycleColExtract32(int cycles = DefaltCycleCount)
        {
            for(var j = 0; j< cycles; j++)
            {
                var src = Polyrand.BitMatrix32();
                for(var c = 0; c < src.ColCount; c ++)
                {
                    var col = src.ColVec(c);
                    for(var r=0; r<src.RowCount; r++)
                        Claim.eq(col[r], src[r,c]);
                }
            }

        }

        void CycleColExtract16(int cycles = DefaltCycleCount)
        {
            for(var j = 0; j< cycles; j++)
            {
                var src = Polyrand.BitMatrix16();
                for(var c = 0; c < src.ColCount; c ++)
                {
                    var col = src.ColVector(c);
                    for(var r=0; r<src.RowCount; r++)
                        Claim.eq(col[r], src[r,c]);
                }
            }

        }

        void CycleColExtract8(int cycles = DefaltCycleCount)
        {
            for(var j = 0; j< cycles; j++)
            {
                var src = Polyrand.BitMatrix8();
                for(var c = 0; c < src.ColCount; c ++)
                {
                    var col = src.ColVector(c);
                    for(var r=0; r<src.RowCount; r++)
                        Claim.eq(col[r], src[r,c]);
                }
            }

        }

        public void eq32()
        {
            var x = Polyrand.BitMatrix32();
            var y = Polyrand.BitMatrix32();
            Claim.nea(x.Equals(y));
            Claim.yea(x.Equals(x));
            Claim.yea(y.Equals(y));
        }

        public void eq64()
        {
            var x = Polyrand.BitMatrix64();
            var y = Polyrand.BitMatrix64();
            Claim.nea(x.Equals(y));
            Claim.nea(x == y);
            Claim.yea(x != y);

            Claim.yea(x.Equals(x));
            Claim.yea(x == x);

            Claim.yea(y.Equals(y));
            Claim.yea(y == y);
        }

        public void flip64()
        {
            
            var x = Polyrand.BitMatrix64();
            var y = x.Replicate();
            var xff = -(-x);
            Claim.yea(xff == y);

            var c = Polyrand.BitMatrix64();
            var a = span<ulong>(64);
            for(var i = 0; i<64; i++)
                a[i] = ~ c.RowData(i);
            var b = BitMatrix64.Load(a);
            Claim.yea(b == -c);        
        }


    }


}