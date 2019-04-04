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

    partial class Operative
    {

        public interface Negatable<T> : Subtractive<T>
        {
            /// <summary>
            /// Unary negation of input
            /// </summary>
            /// <param name="x">The input value</param>
            T negate(T x);

        }

    }

    partial class Structures
    {
        public interface Negatable<S> : Subtractive<S>
            where S : Negatable<S>, new()
        {
            /// <summary>
            /// Unary structural negation
            /// </summary>
            /// <param name="a">The input value</param>
            S negate();
        }

    }

    public readonly struct Negatable 
        : Negatable<sbyte>, Negatable<short>, 
          Negatable<int>, Negatable<long>, 
          Negatable<BigInteger>,
          Negatable<float>, Negatable<double>, 
          Negatable<decimal>
    {
        public static readonly Negatable Inhabitant = default;

        [MethodImpl(Inline)]
        public sbyte negate(sbyte x)
            => (sbyte)-x;

        [MethodImpl(Inline)]
        public short negate(short x)
            => (short)-x;

        [MethodImpl(Inline)]
        public int negate(int x)
            => -x;

        [MethodImpl(Inline)]
        public long negate(long x)
            => -x;

        [MethodImpl(Inline)]
        public BigInteger negate(BigInteger x)
            => -x;

        [MethodImpl(Inline)]
        public float negate(float x)
            => -x;

        [MethodImpl(Inline)]
        public decimal negate(decimal x)
            => -x;

        [MethodImpl(Inline)]
        public double negate(double x)
            => -x;

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