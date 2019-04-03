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

        public interface Negatable<T>
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
        public interface Negatable<S>
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
    }
}