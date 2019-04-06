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
        public readonly struct Ordered : 
            Ordered<byte>,
            Ordered<sbyte>, 
            Ordered<short>, 
            Ordered<ushort>, 
            Ordered<int>, 
            Ordered<uint>,
            Ordered<long>, 
            Ordered<ulong>,
            Ordered<float>, 
            Ordered<double>, 
            Ordered<decimal>,
            Ordered<BigInteger>
                
        {
            static readonly Ordered Inhabitant = default;

            [MethodImpl(Inline)]
            public static Ordered<T> Operator<T>() 
                => cast<Ordered<T>>(Inhabitant);

            [MethodImpl(Inline)]
            public bool lt(byte lhs, byte rhs)
                => lhs < rhs;

            [MethodImpl(Inline)]
            public bool lt(sbyte lhs, sbyte rhs)
                => lhs < rhs;

            [MethodImpl(Inline)]
            public bool lt(ushort lhs, ushort rhs)
                => lhs < rhs;

            [MethodImpl(Inline)]
            public bool lt(short lhs, short rhs)
                => lhs < rhs;

            [MethodImpl(Inline)]
            public bool lt(int lhs, int rhs)
                => lhs < rhs;

            [MethodImpl(Inline)]
            public bool lt(uint lhs, uint rhs)
                => lhs < rhs;

            [MethodImpl(Inline)]
            public bool lt(long lhs, long rhs)
                => lhs < rhs;

            [MethodImpl(Inline)]
            public bool lt(ulong lhs, ulong rhs)
                => lhs < rhs;

            [MethodImpl(Inline)]
            public bool lt(decimal lhs, decimal rhs)
                => lhs < rhs;

            [MethodImpl(Inline)]
            public bool lt(double lhs, double rhs)
                => lhs < rhs;

            [MethodImpl(Inline)]
            public bool lt(float lhs, float rhs)
                => lhs < rhs;

            [MethodImpl(Inline)]
            public bool lt(BigInteger lhs, BigInteger rhs)
                => lhs < rhs;

            [MethodImpl(Inline)]
            public bool lteq(byte lhs, byte rhs)
                => lhs <= rhs;

            [MethodImpl(Inline)]
            public bool lteq(sbyte lhs, sbyte rhs)
                => lhs <= rhs;

            [MethodImpl(Inline)]
            public bool lteq(ushort lhs, ushort rhs)
                => lhs <= rhs;

            [MethodImpl(Inline)]
            public bool lteq(short lhs, short rhs)
                => lhs <= rhs;

            [MethodImpl(Inline)]
            public bool lteq(int lhs, int rhs)
                => lhs <= rhs;

            [MethodImpl(Inline)]
            public bool lteq(uint lhs, uint rhs)
                => lhs <= rhs;

            [MethodImpl(Inline)]
            public bool lteq(long lhs, long rhs)
                => lhs <= rhs;

            [MethodImpl(Inline)]
            public bool lteq(ulong lhs, ulong rhs)
                => lhs <= rhs;

            [MethodImpl(Inline)]
            public bool lteq(decimal lhs, decimal rhs)
                => lhs <= rhs;

            [MethodImpl(Inline)]
            public bool lteq(double lhs, double rhs)
                => lhs <= rhs;

            [MethodImpl(Inline)]
            public bool lteq(float lhs, float rhs)
                => lhs <= rhs;

            [MethodImpl(Inline)]
            public bool lteq(BigInteger lhs, BigInteger rhs)
                => lhs <= rhs;
 
            [MethodImpl(Inline)]
            public bool gt(byte lhs, byte rhs)
                => lhs > rhs;

            [MethodImpl(Inline)]
            public bool gt(sbyte lhs, sbyte rhs)
                => lhs > rhs;

            [MethodImpl(Inline)]
            public bool gt(ushort lhs, ushort rhs)
                => lhs > rhs;

            [MethodImpl(Inline)]
            public bool gt(short lhs, short rhs)
                => lhs > rhs;

            [MethodImpl(Inline)]
            public bool gt(int lhs, int rhs)
                => lhs > rhs;

            [MethodImpl(Inline)]
            public bool gt(uint lhs, uint rhs)
                => lhs > rhs;

            [MethodImpl(Inline)]
            public bool gt(long lhs, long rhs)
                => lhs > rhs;

            [MethodImpl(Inline)]
            public bool gt(ulong lhs, ulong rhs)
                => lhs > rhs;

            [MethodImpl(Inline)]
            public bool gt(decimal lhs, decimal rhs)
                => lhs > rhs;

            [MethodImpl(Inline)]
            public bool gt(double lhs, double rhs)
                => lhs > rhs;

            [MethodImpl(Inline)]
            public bool gt(float lhs, float rhs)
                => lhs > rhs;

            [MethodImpl(Inline)]
            public bool gt(BigInteger lhs, BigInteger rhs)
                => lhs > rhs;

            [MethodImpl(Inline)]
            public bool gteq(byte lhs, byte rhs)
                => lhs >= rhs;

            [MethodImpl(Inline)]
            public bool gteq(sbyte lhs, sbyte rhs)
                => lhs >= rhs;

            [MethodImpl(Inline)]
            public bool gteq(ushort lhs, ushort rhs)
                => lhs >= rhs;

            [MethodImpl(Inline)]
            public bool gteq(short lhs, short rhs)
                => lhs >= rhs;

            [MethodImpl(Inline)]
            public bool gteq(int lhs, int rhs)
                => lhs >= rhs;

            [MethodImpl(Inline)]
            public bool gteq(uint lhs, uint rhs)
                => lhs >= rhs;

            [MethodImpl(Inline)]
            public bool gteq(long lhs, long rhs)
                => lhs >= rhs;

            [MethodImpl(Inline)]
            public bool gteq(ulong lhs, ulong rhs)
                => lhs >= rhs;

            [MethodImpl(Inline)]
            public bool gteq(decimal lhs, decimal rhs)
                => lhs >= rhs;

            [MethodImpl(Inline)]
            public bool gteq(double lhs, double rhs)
                => lhs >= rhs;

            [MethodImpl(Inline)]
            public bool gteq(float lhs, float rhs)
                => lhs >= rhs;

            [MethodImpl(Inline)]
            public bool gteq(BigInteger lhs, BigInteger rhs)
                => lhs >= rhs;
        }
    }

}