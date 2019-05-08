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
        public readonly struct Equality : 
            ISemigroupOps<byte>, 
            ISemigroupOps<sbyte>, 
            ISemigroupOps<short>, 
            ISemigroupOps<ushort>, 
            ISemigroupOps<int>, 
            ISemigroupOps<uint>,
            ISemigroupOps<long>, 
            ISemigroupOps<ulong>,
            ISemigroupOps<float>, 
            ISemigroupOps<double>, 
            ISemigroupOps<decimal>,
            ISemigroupOps<BigInteger>
                
        {
            static readonly Equality Inhabitant = default;

            [MethodImpl(Inline)]
            public static ISemigroupOps<T> Operator<T>() 
                => cast<ISemigroupOps<T>>(Inhabitant);

            // !! eq
            // !! -------------------------------------------------------------

            [MethodImpl(Inline)]
            public bool eq(byte lhs, byte rhs)
                => lhs == rhs;

            [MethodImpl(Inline)]
            public bool eq(sbyte lhs, sbyte rhs)
                => lhs == rhs;

            [MethodImpl(Inline)]
            public bool eq(ushort lhs, ushort rhs)
                => lhs == rhs;

            [MethodImpl(Inline)]
            public bool eq(short lhs, short rhs)
                => lhs == rhs;

            [MethodImpl(Inline)]
            public bool eq(int lhs, int rhs)
                => lhs == rhs;

            [MethodImpl(Inline)]
            public bool eq(uint lhs, uint rhs)
                => lhs == rhs;

            [MethodImpl(Inline)]
            public bool eq(long lhs, long rhs)
                => lhs == rhs;


            [MethodImpl(Inline)]
            public bool eq(ulong lhs, ulong rhs)
                => lhs == rhs;


            [MethodImpl(Inline)]
            public bool eq(double lhs, double rhs)
                => lhs == rhs;

            [MethodImpl(Inline)]
            public bool eq(float lhs, float rhs)
                => lhs == rhs;

            [MethodImpl(Inline)]
            public bool eq(decimal lhs, decimal rhs)
                => lhs == rhs;


            [MethodImpl(Inline)]
            public bool eq(BigInteger lhs, BigInteger rhs)
                => lhs == rhs;

            // !! neq
            // !! -------------------------------------------------------------
            
            [MethodImpl(Inline)]
            public bool neq(byte lhs, byte rhs)
                => lhs != rhs;

            [MethodImpl(Inline)]
            public bool neq(sbyte lhs, sbyte rhs)
                => lhs != rhs;

            [MethodImpl(Inline)]
            public bool neq(ushort lhs, ushort rhs)
                => lhs != rhs;

            [MethodImpl(Inline)]
            public bool neq(short lhs, short rhs)
                => lhs != rhs;

            [MethodImpl(Inline)]
            public bool neq(int lhs, int rhs)
                => lhs != rhs;

            [MethodImpl(Inline)]
            public bool neq(uint lhs, uint rhs)
                => lhs != rhs;

            [MethodImpl(Inline)]
            public bool neq(long lhs, long rhs)
                => lhs != rhs;


            [MethodImpl(Inline)]
            public bool neq(ulong lhs, ulong rhs)
                => lhs != rhs;


            [MethodImpl(Inline)]
            public bool neq(double lhs, double rhs)
                => lhs != rhs;

            [MethodImpl(Inline)]
            public bool neq(float lhs, float rhs)
                => lhs != rhs;

            [MethodImpl(Inline)]
            public bool neq(decimal lhs, decimal rhs)
                => lhs != rhs;


            [MethodImpl(Inline)]
            public bool neq(BigInteger lhs, BigInteger rhs)
                => lhs != rhs;

        }

    }

}}