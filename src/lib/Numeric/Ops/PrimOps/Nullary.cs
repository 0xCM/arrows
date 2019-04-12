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
            Nullary<byte>,
            Nullary<sbyte>,
            Nullary<short>,
            Nullary<ushort>,
            Nullary<int>,
            Nullary<uint>,
            Nullary<long>,
            Nullary<ulong>,
            Nullary<float>,
            Nullary<double>,
            Nullary<decimal>,
            Nullary<BigInteger>

        {
            static readonly Nullary Inhabitant = default;

            [MethodImpl(Inline)]
            public static Nullary<T> Operator<T>() 
                => cast<Nullary<T>>(Inhabitant);


            byte Nullary<byte>.zero
            {
                [MethodImpl(Inline)]
                get => 0;
            }

            sbyte Nullary<sbyte>.zero
            {
                [MethodImpl(Inline)]
                get => 0;
            }

            short Nullary<short>.zero
            {
                [MethodImpl(Inline)]
                get => 0;
            }

            ushort Nullary<ushort>.zero
            {
                [MethodImpl(Inline)]
                get => 0;
            }

            int Nullary<int>.zero
            {
                [MethodImpl(Inline)]
                get => 0;
            }

            uint Nullary<uint>.zero
            {
                [MethodImpl(Inline)]
                get => 0;
            }

            long Nullary<long>.zero
            {
                [MethodImpl(Inline)]
                get => 0;
            }

            ulong Nullary<ulong>.zero
            {
                [MethodImpl(Inline)]
                get => 0;
            }

            float Nullary<float>.zero
            {
                [MethodImpl(Inline)]
                get => 0;
            }

            double Nullary<double>.zero
            {
                [MethodImpl(Inline)]
                get => 0;
            }

            decimal Nullary<decimal>.zero
            {
                [MethodImpl(Inline)]
                get => 0;
            }

            BigInteger Nullary<BigInteger>.zero
            {
                [MethodImpl(Inline)]
                get => BigInteger.Zero;
            }
        }

    }
}}