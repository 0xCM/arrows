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
    using static zfunc;

    using static Operative;

    partial class PrimOps { partial class Reify {
        public readonly struct Unital :
            IUnitalOps<byte>,
            IUnitalOps<sbyte>,
            IUnitalOps<short>,
            IUnitalOps<ushort>,
            IUnitalOps<int>,
            IUnitalOps<uint>,
            IUnitalOps<long>,
            IUnitalOps<ulong>,
            IUnitalOps<float>,
            IUnitalOps<double>,
            IUnitalOps<decimal>,
            IUnitalOps<BigInteger>

        {
            static readonly Unital Inhabitant = default;

            [MethodImpl(Inline)]
            public static IUnitalOps<T> Operator<T>() 
                => cast<IUnitalOps<T>>(Inhabitant);

            byte IUnitalOps<byte>.one 
            {
                [MethodImpl(Inline)]
                get => 1;
            }

            sbyte IUnitalOps<sbyte>.one 
            {
                [MethodImpl(Inline)]
                get => 1;
            }

            short IUnitalOps<short>.one 
            {
                [MethodImpl(Inline)]
                get => 1;
            }

            ushort IUnitalOps<ushort>.one 
            {
                [MethodImpl(Inline)]
                get => 1;
            }

            int IUnitalOps<int>.one 
            {
                [MethodImpl(Inline)]
                get => 1;
            }

            uint IUnitalOps<uint>.one 
            {
                [MethodImpl(Inline)]
                get => 1;
            }

            long IUnitalOps<long>.one 
            {
                [MethodImpl(Inline)]
                get => 1;
            }

            ulong IUnitalOps<ulong>.one 
            {
                [MethodImpl(Inline)]
                get => 1;
            }

            float IUnitalOps<float>.one 
            {
                [MethodImpl(Inline)]
                get => 1;
            }

            double IUnitalOps<double>.one 
            {
                [MethodImpl(Inline)]
                get => 1;
            }

            decimal IUnitalOps<decimal>.one 
            {
                [MethodImpl(Inline)]
                get => 1;
            }

            BigInteger IUnitalOps<BigInteger>.one 
            {
                [MethodImpl(Inline)]
                get => BigInteger.One;
            }
        }

    }
}}