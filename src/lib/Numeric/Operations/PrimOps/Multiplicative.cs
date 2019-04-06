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
        public readonly struct Multiplicative : 
            Multiplicative<byte>, 
            Multiplicative<sbyte>, 
            Multiplicative<short>,
            Multiplicative<ushort>, 
            Multiplicative<int>,
            Multiplicative<uint>,
            Multiplicative<long>,
            Multiplicative<ulong>,            
            Multiplicative<float>, 
            Multiplicative<double>, 
            Multiplicative<decimal>,
            Multiplicative<BigInteger>                    
        {
            static readonly Multiplicative Inhabitant = default;

            [MethodImpl(Inline)]
            public static Multiplicative<T> Operator<T>() 
                => cast<Multiplicative<T>>(Inhabitant);

            [MethodImpl(Inline)]
            public sbyte mul(sbyte lhs, sbyte rhs)
                => (sbyte)(lhs * rhs);

            [MethodImpl(Inline)]
            public byte mul(byte lhs, byte rhs)
                => (byte)(lhs * rhs);

            [MethodImpl(Inline)]
            public short mul(short lhs, short rhs)
                => (short)(lhs * rhs);
        
            [MethodImpl(Inline)]
            public ushort mul(ushort lhs, ushort rhs)
                => (ushort)(lhs * rhs);

            [MethodImpl(Inline)]
            public int mul(int lhs, int rhs)
                => lhs * rhs;

            [MethodImpl(Inline)]
            public uint mul(uint lhs, uint rhs)
                => lhs * rhs;

            [MethodImpl(Inline)]
            public long mul(long lhs, long rhs)
                => lhs * rhs;

            [MethodImpl(Inline)]
            public ulong mul(ulong lhs, ulong rhs)
                => lhs * rhs;

            [MethodImpl(Inline)]
            public float mul(float lhs, float rhs)
                => lhs * rhs;

            [MethodImpl(Inline)]
            public double mul(double lhs, double rhs)
                => lhs * rhs;

            [MethodImpl(Inline)]
            public decimal mul(decimal lhs, decimal rhs)
                => lhs * rhs;

            [MethodImpl(Inline)]
            public BigInteger mul(BigInteger lhs, BigInteger rhs)
                => lhs * rhs;
        }

    }
}