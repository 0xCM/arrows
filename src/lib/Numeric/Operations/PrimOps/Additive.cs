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

    partial class PrimOps
    {
        public readonly struct Additive : 
            Additive<byte>, 
            Additive<sbyte>, 
            Additive<short>, 
            Additive<ushort>, 
            Additive<int>, 
            Additive<uint>,
            Additive<long>, 
            Additive<ulong>,
            Additive<float>, 
            Additive<double>, 
            Additive<decimal>,
            Additive<BigInteger>
                
        {
            static readonly Additive Inhabitant = default;

            [MethodImpl(Inline)]
            public static Additive<T> Operator<T>() 
                => cast<Additive<T>>(Inhabitant);

            [MethodImpl(Inline)]
            public byte add(byte lhs, byte rhs)
                => (byte)(lhs + rhs);

            [MethodImpl(Inline)]
            public sbyte add(sbyte lhs, sbyte rhs)
                => (sbyte)(lhs + rhs);

            [MethodImpl(Inline)]
            public ushort add(ushort lhs, ushort rhs)
                => (ushort)(lhs + rhs);

            [MethodImpl(Inline)]
            public short add(short lhs, short rhs)
                => (short)(lhs + rhs);

            [MethodImpl(Inline)]
            public int add(int lhs, int rhs)
                => lhs + rhs;

            [MethodImpl(Inline)]
            public uint add(uint lhs, uint rhs)
                => lhs + rhs;

            [MethodImpl(Inline)]
            public ulong add(ulong lhs, ulong rhs)
                => lhs + rhs;

            [MethodImpl(Inline)]
            public decimal add(decimal lhs, decimal rhs)
                => lhs + rhs;

            [MethodImpl(Inline)]
            public double add(double lhs, double rhs)
                => lhs + rhs;

            [MethodImpl(Inline)]
            public float add(float lhs, float rhs)
                => lhs + rhs;

            [MethodImpl(Inline)]
            public BigInteger add(BigInteger lhs, BigInteger rhs)
                => lhs + rhs;

            [MethodImpl(Inline)]
            public long add(long lhs, long rhs)
                => lhs + rhs;
        }

    }

}