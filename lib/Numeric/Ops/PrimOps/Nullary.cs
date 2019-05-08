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
        public readonly struct Nullary :
            INullaryOps<byte>,
            INullaryOps<sbyte>,
            INullaryOps<short>,
            INullaryOps<ushort>,
            INullaryOps<int>,
            INullaryOps<uint>,
            INullaryOps<long>,
            INullaryOps<ulong>,
            INullaryOps<float>,
            INullaryOps<double>,
            INullaryOps<decimal>,
            INullaryOps<BigInteger>

        {
            static readonly Nullary Inhabitant = default;

            [MethodImpl(Inline)]
            public static INullaryOps<T> Operator<T>() 
                => cast<INullaryOps<T>>(Inhabitant);


            byte INullaryOps<byte>.zero
            {
                [MethodImpl(Inline)]
                get => 0;
            }

            sbyte INullaryOps<sbyte>.zero
            {
                [MethodImpl(Inline)]
                get => 0;
            }

            short INullaryOps<short>.zero
            {
                [MethodImpl(Inline)]
                get => 0;
            }

            ushort INullaryOps<ushort>.zero
            {
                [MethodImpl(Inline)]
                get => 0;
            }

            int INullaryOps<int>.zero
            {
                [MethodImpl(Inline)]
                get => 0;
            }

            uint INullaryOps<uint>.zero
            {
                [MethodImpl(Inline)]
                get => 0;
            }

            long INullaryOps<long>.zero
            {
                [MethodImpl(Inline)]
                get => 0;
            }

            ulong INullaryOps<ulong>.zero
            {
                [MethodImpl(Inline)]
                get => 0;
            }

            float INullaryOps<float>.zero
            {
                [MethodImpl(Inline)]
                get => 0;
            }

            double INullaryOps<double>.zero
            {
                [MethodImpl(Inline)]
                get => 0;
            }

            decimal INullaryOps<decimal>.zero
            {
                [MethodImpl(Inline)]
                get => 0;
            }

            BigInteger INullaryOps<BigInteger>.zero
            {
                [MethodImpl(Inline)]
                get => BigInteger.Zero;
            }
        }

    }
}}