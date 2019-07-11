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

    public class BitVectorTest : UnitTest<BitVectorTest>
    {
        public void TestSpanBits()
        {
            var src = Random.Span<byte>(Pow2.T03);
            var bvSrc = BitVector64.Define(BitConverter.ToUInt64(src));

            for(var i=0; i< Pow2.T03*8; i++)
                Claim.eq(src.TestBit(i), bvSrc.TestBit(i));
        }

        void BitVectorCreateU64()
        {
            var samples = Pow2.T08;
            var dim = new N64();
            var segcount = dim / SizeOf<uint>.BitSize;
            var src = Random.Span<uint>(samples);
            for(var i=0; i<src.Length - segcount; i++)
            {
                var bvSrc = src.Slice(i, segcount);
                var bv = bvSrc.ToBitVector(dim);
                var x = Bits.pack(bvSrc[0], bvSrc[1]);
                for(var j = 0; j < dim; j++)
                    Claim.eq(Bits.test(x,j).ToBit(), bv[j]);                
            }
        }

        void BitVectorCreate<N,T>(int samples, N dim = default)
            where N : ITypeNat, new()
            where T : struct
        {
            var src = Random.Span<T>(samples);
            for(var i=0; i<samples; i++)
            {
                var bvSrc = src.Slice(i,1);
                var bv = bvSrc.ToBitVector(dim);
                var x = src[i];
                for(var j = 0; j < (int)dim.value; j++)
                    Claim.eq(gbits.test(x,j).ToBit(), bv[j]);                

            }

        }

        public void BitVectorCreate()
        {
            BitVectorCreateU64();
            BitVectorCreate<N63,ulong>(Pow2.T08);
            BitVectorCreate<N13,ushort>(Pow2.T08);
            BitVectorCreate<N32,uint>(Pow2.T08);
        }

        public void ScalarProduct1()
        {
            var x = Random.BitMatrix<N5,N5,byte>();
            var y = x.Transpose();
            var z = BitMatrix.Zeros<N5,byte>();
            for(var i = 0; i<x.RowCount; i++)
            {
                var rowX = x.Row(i);
                for(var j=0; j<y.RowCount; j++)
                {
                    var rowY = y.Row(j);
                    z[i,j] = rowX * rowY;
                }
            }
            
        }

        public void ScalarProduct2()
        {
            byte xr0 = 0b10101;
            byte xr1 = 0b00101;
            byte xr2 = 0b11000;
            byte xr3 = 0b00111;
            byte xr4 = 0b01011;
            var x = BitMatrix.Define(N5.Rep, N5.Rep, xr0,xr1,xr2, xr3,xr4);
            var y = x.Transpose();
            var z = BitMatrix.Zeros<N5,byte>();            
            for(var i = 0; i<x.RowCount; i++)
            {
                var rowX = x.Row(i);
                for(var j=0; j<y.RowCount; j++)
                {
                    var rowY = y.Row(j);
                    z[i,j] = rowX * rowY;
                }
            }
            Claim.eq(Bit.On,z[0,0]);


        }

    }

}


