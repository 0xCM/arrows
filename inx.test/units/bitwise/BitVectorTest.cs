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


    }

}


