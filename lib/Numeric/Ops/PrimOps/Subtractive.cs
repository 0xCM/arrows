//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using static zcore;

    using static Operative;

    partial class PrimOps { partial class Reify {

        public readonly struct Subtractive : 
            Subtractive<byte>, 
            Subtractive<sbyte>, 
            Subtractive<short>, 
            Subtractive<ushort>, 
            Subtractive<int>, 
            Subtractive<uint>, 
            Subtractive<long>,             
            Subtractive<ulong>, 
            Subtractive<float>, 
            Subtractive<double>, 
            Subtractive<decimal>,
            Subtractive<BigInteger>
        {
            static readonly Subtractive Inhabitant = default;

            public static Subtractive<T> Operator<T>() 
                => cast<Subtractive<T>>(Inhabitant);

            [MethodImpl(Inline)]
            public sbyte sub(sbyte lhs, sbyte rhs)
                => (sbyte)(lhs - rhs);

            [MethodImpl(Inline)]
            public byte sub(byte lhs, byte rhs)
                => (byte)(lhs - rhs);

            [MethodImpl(Inline)]
            public short sub(short lhs, short rhs)
                => (short)(lhs - rhs);

            [MethodImpl(Inline)]
            public ushort sub(ushort lhs, ushort rhs)
                => (ushort)(lhs - rhs);

            [MethodImpl(Inline)]
            public int sub(int lhs, int rhs)
                => lhs - rhs;

            [MethodImpl(Inline)]
            public uint sub(uint lhs, uint rhs)
                => lhs - rhs;

            [MethodImpl(Inline)]
            public long sub(long lhs, long rhs)
                => lhs - rhs;

            [MethodImpl(Inline)]
            public ulong sub(ulong lhs, ulong rhs)
                => lhs - rhs;

            [MethodImpl(Inline)]
            public BigInteger sub(BigInteger lhs, BigInteger rhs)
                => lhs - rhs;

            [MethodImpl(Inline)]
            public float sub(float lhs, float rhs)
                => lhs - rhs;

            [MethodImpl(Inline)]
            public double sub(double lhs, double rhs)
                => lhs - rhs;

            [MethodImpl(Inline)]
            public decimal sub(decimal lhs, decimal rhs)
                => lhs - rhs;

        }

    }    
  }

    partial class PrimalIndex
    {

        [MethodImpl(Inline)]
        public static Index<sbyte> Sub(this Index<sbyte> lhs, Index<sbyte> rhs)
            => fuse(lhs, rhs,(x,y) => (sbyte)(x - y));

        [MethodImpl(Inline)]
        public static Index<byte> Sub(this Index<byte> lhs, Index<byte> rhs)
            => fuse(lhs,rhs,(x,y) => (byte)(x - y));

        [MethodImpl(Inline)]
        public static Index<short> Sub(this Index<short> lhs, Index<short> rhs)
            => fuse(lhs,rhs,(x,y) => (short)(x - y));

        [MethodImpl(Inline)]
        public static Index<ushort> Sub(this Index<ushort> lhs, Index<ushort> rhs)
            => fuse(lhs,rhs,(x,y) => (ushort)(x - y));

        [MethodImpl(Inline)]
        public static Index<int> Sub(this Index<int> lhs, Index<int> rhs)
            => fuse(lhs,rhs,(x,y) => x - y);

        [MethodImpl(Inline)]
        public static Index<uint> Sub(this Index<uint> lhs, Index<uint> rhs)
            => fuse(lhs,rhs,(x,y) => x - y);

        [MethodImpl(Inline)]
        public static Index<long> Sub(this Index<long> lhs, Index<long> rhs)
            => fuse(lhs, rhs,(x,y) => x - y);

        [MethodImpl(Inline)]
        public static Index<ulong> Sub(this Index<ulong> lhs, Index<ulong> rhs)
            => fuse(lhs, rhs,(x,y) => x - y);

        [MethodImpl(Inline)]
        public static Index<float> Sub(this Index<float> lhs, Index<float> rhs)
            => fuse(lhs,rhs,(x,y) => x - y);

        [MethodImpl(Inline)]
        public static Index<double> Sub(this Index<double> lhs, Index<double> rhs)
            => fuse(lhs,rhs,(x,y) => x - y);

        [MethodImpl(Inline)]
        public static Index<decimal> Sub(this Index<decimal> lhs, Index<decimal> rhs)
            => fuse(lhs,rhs,(x,y) => x - y);

        [MethodImpl(Inline)]
        public static Index<BigInteger> Sub(this Index<BigInteger> lhs, Index<BigInteger> rhs)
            => fuse(lhs,rhs,(x,y) => x - y);

    }


}