//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static Nats;

    sealed class BitVectorTest : UnitTest<BitVectorTest>
    {

        public void SetBits()
        {
            var bv = default(BitVectorU64);
            var it = It.Define(Pow2.MinExponent, Pow2.MaxExponent + 1);
            while(++it)
                bv[it] = 1;

            Claim.eq(UInt64.MaxValue, bv);
        }

        public void Split()
        {
            var bv = BitVectorU64.Define(UInt64.MaxValue);
            Claim.eq(UInt32.MaxValue, bv.Lo);
            Claim.eq(UInt32.MaxValue, bv.Hi);
        }

        void OrOp<N,T>(T lhs, T rhs)
            where T : struct
            where N : INatPow2, new()
        {
            var x0 = BitVector.Define(lhs);
            var x1 = BitVector.Define(rhs) ;
            var x = x0 | x1;
            var y0 = BitVector.Load<N,T>(ref lhs);
            var y1 = BitVector.Load<N,T>(ref rhs);
            var y =  y0 | y1;
            Claim.eq(x.BitString(),y.BitString());
        }

        void OrOps<N,T>()
            where T : struct
            where N : INatPow2, new()
        {
            var src = Randomizer.Pairs<T>(Pow2.T04).ToReadOnlyList();
            for(var i = 0; i<src.Count; i++)
                OrOp<N,T>(src[i].Left, src[i].Right);
        }

        void AndOp<N,T>(T lhs, T rhs)
            where T : struct
            where N : INatPow2, new()
        {
            var x0 = BitVector.Define(lhs);
            var x1 = BitVector.Define(rhs) ;
            var x = x0 & x1;
            var y0 = BitVector.Load<N,T>(ref lhs);
            var y1 = BitVector.Load<N,T>(ref rhs);
            var y =  y0 & y1;
            Claim.eq(x.BitString(),y.BitString());
        }

        void AndOps<N,T>()
            where T : struct
            where N : INatPow2, new()
        {
            var src = Randomizer.Pairs<T>(Pow2.T04).ToReadOnlyList();
            for(var i = 0; i<src.Count; i++)
                AndOp<N,T>(src[i].Left, src[i].Right);
        }

        void PopCount<N,T>(T src)
            where T : struct
            where N : INatPow2, new()
        {
            var x0 = BitVector.Define(src);
            var x = x0.PopCount();
            var y0 = BitVector.Load<N,T>(ref src);
            var y =  y0.PopCount();
            Claim.eq(x,y);
        }

        void PopCounts<N,T>()
            where T : struct
            where N : INatPow2, new()
        {
            var src = Randomizer.Span<T>(Pow2.T04);
            for(var i = 0; i<src.Length; i++)
                PopCount<N,T>(src[i]);

        }

        void Pack<S,T>()
            where S : struct
            where T : struct
        {
            var szSrc = Unsafe.SizeOf<S>();
            var szDst = Unsafe.SizeOf<T>();
            var sz = szDst / szSrc;
            Claim.lt(szSrc, szDst);

            var src = Randomizer.Span<S>(Pow2.T10).ToReadOnlySpan();
            var srcLen = src.Length;
            var srcByteCount = szSrc * srcLen;
            var dstLen =  srcLen / sz;
            var dstByteCount = szDst * dstLen;
            Claim.eq(srcByteCount, dstByteCount);

            var dst = span<T>(dstLen);
            var packed = gbits.pack(src,dst);
            for(var i =0; i< packed.Length; i++)
            {
                var x = bytes(src.Slice(sz*i, sz));
                var y = bytes(packed[i]);
                Claim.eq(x.Length, y.Length);
                for(var j = 0; j < x.Length; j++)
                    Claim.eq(x[j], y[j]);
            }
        }


        public void Pack()
        {
            Pack<byte,short>();
            Pack<byte,ushort>();
            Pack<byte,int>();
            Pack<byte,uint>();            
            Pack<byte,long>();
            Pack<byte, ulong>();

            Pack<sbyte,short>();
            Pack<sbyte,ushort>();
            Pack<sbyte,int>();
            Pack<sbyte,uint>();            
            Pack<sbyte,long>();
            Pack<sbyte, ulong>();

            Pack<short,int>();
            Pack<short,uint>();            
            Pack<short,long>();
            Pack<short, ulong>();

            Pack<ushort,int>();
            Pack<ushort,uint>();            
            Pack<ushort,long>();
            Pack<ushort, ulong>();

            Pack<int,long>();
            Pack<int, ulong>();

            Pack<uint,long>();
            Pack<uint, ulong>();

        }

        public void AndOps()
        {
            AndOps<N8,sbyte>();
            AndOps<N8,byte>();
           
            AndOps<N16,short>();
            AndOps<N16,ushort>();
           
            AndOps<N32,int>();
            AndOps<N32,uint>();
           
            AndOps<N64,long>();
            AndOps<N64,ulong>();
                        
        }

        public void OrOps()
        {
            OrOps<N8,sbyte>();
            OrOps<N8,byte>();
           
            OrOps<N16,short>();
            OrOps<N16,ushort>();
           
            OrOps<N32,int>();
            OrOps<N32,uint>();
           
            OrOps<N64,long>();
            OrOps<N64,ulong>();                        
        }

        public void PopCounts()
        {
            PopCounts<N8, byte>();
            PopCounts<N16, ushort>();
            PopCounts<N32, uint>();
            PopCounts<N64, ulong>();
        }

        public void NatBits()
        {
            var bits = N1024;
            var bytes = (int)(N1024.value / 8);
        
            var lhs = Randomizer.Span<byte>(bytes).ToReadOnlySpan();
            var rhs = Randomizer.Span<byte>(bytes).ToReadOnlySpan();
            var x = BitVector.Define(lhs,bits);
            var y = BitVector.Define(rhs,bits);            
            var z0 = lhs.And(rhs).ToBytes();
            var z1 = (x & y).Bytes();
            Claim.eq(z0.Length, z1.Length);
            Claim.@true(z0.Eq(z1));

        }

    }

}