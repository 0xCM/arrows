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

        public interface Absolutive<T> 
        {
            T abs(T x);
        }


    }

    partial class Structures
    {

        public interface Absolitive<S> : Structure<S>
            where S : Absolitive<S>,new()
        {
            S abs();
        }

    }

    public readonly struct Absolitive
        : Absolutive<sbyte>, Absolutive<short>, 
          Absolutive<int>, Absolutive<long>, 
          Absolutive<BigInteger>,
          Absolutive<float>, Absolutive<double>, 
          Absolutive<decimal>
    {
        public static readonly Absolitive Inhabitant = default;
        
        [MethodImpl(Inline)]
        public sbyte abs(sbyte x)
            => (sbyte)(x >= 0 ? x : -x);

        [MethodImpl(Inline)]
        public short abs(short x)
            => (short)(x >= 0 ? x : -x);

        [MethodImpl(Inline)]
        public int abs(int x)
            => x >= 0 ? x : -x;

        [MethodImpl(Inline)]
        public long abs(long x)
            => x >= 0 ? x : -x;

        [MethodImpl(Inline)]
        public BigInteger abs(BigInteger x)
            => x >= 0 ? x : -x;

        [MethodImpl(Inline)]
        public float abs(float x)
            => x >= 0 ? x : -x;

        [MethodImpl(Inline)]
        public decimal abs(decimal x)
            => x >= 0 ? x : -x;

        [MethodImpl(Inline)]
        public double abs(double x)
            => x >= 0 ? x : -x;
    }
}