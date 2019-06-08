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
        /// <summary>
        /// Creates a natural bitvector from a 1-element source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> Load<N,T>(ref T src, N rep = default)        
            where T : struct
            where N : INatPow2, new()
                => BitVector<N,T>.Load(ref src);

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


        void OrOps<N,T>()
            where T : struct
            where N : INatPow2, new()
        {
            var len = (int)new N().value;
            var lhs = Randomizer.Span<T>(len);
            var rhs = Randomizer.Span<T>(len);

            var vX = Load<N,T>(ref lhs[0]);
            var vY = Load<N,T>(ref rhs[0]);
            var vZ = vX | vY;
            for(var i = 0; i<len; i++)
            {
                var x1 = BitVector.Define(lhs[i]);
                var x2 = BitVector.Define(rhs[i]);
                var x = x1 | x2;
                Claim.eq(x.BitString(),  gbits.bitstring(vZ.Component(i)));
            }
        }


        void AndOps<N,T>()
            where T : struct
            where N : INatPow2, new()
        {
            var len = (int)new N().value;
            var lhs = Randomizer.Span<T>(len);
            var rhs = Randomizer.Span<T>(len);

            var vX = Load<N,T>(ref lhs[0]);
            var vY = Load<N,T>(ref rhs[0]);
            var vZ = vX & vY;
            for(var i = 0; i<len; i++)
            {
                var x1 = BitVector.Define(lhs[i]);
                var x2 = BitVector.Define(rhs[i]);
                var x = x1 & x2;
                Claim.eq(x.BitString(),  gbits.bitstring(vZ.Component(i)));
            }
                
        }

        void PopCounts<N,T>()
            where T : struct
            where N : INatPow2, new()
        {
            var count1 = 0ul;
            var count2 = 0ul;
            var src = Randomizer.Span<T>((int)new N().value);
            for(var i = 0; i<src.Length; i++)
            {
                var x = BitVector.Define(src[i]);
                count1 += x.Pop();
            }

            var y = Load<N,T>(ref src[0]);
            count2 = y.PopCount();

            Claim.eq(count1, count2);        

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

        /// <summary>
        /// Creates a natural b1itvector from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> Define<N,T>(in ReadOnlySpan<T> src, N len = default(N))        
            where T : struct
            where N : INatPow2, new()
                => BitVector<N,T>.Define(in src);

        public void NatBitsTest()
        {
            var rep = N1024;        
            var len = (int)rep.value;
            var lhs = Randomizer.Span<byte>(len).ToReadOnlySpan();
            var rhs = Randomizer.Span<byte>(len).ToReadOnlySpan();
            var x = Define(lhs,rep);
            var y = Define(rhs,rep);            
            var z0 = lhs.And(rhs).ToBytes();
            var z1 = (x & y).Bytes();
            Claim.eq(z0.Length, z1.Length);
            Claim.@true(z0.Eq(z1));

        }

    }

}