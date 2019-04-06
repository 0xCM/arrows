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
        public readonly struct Unital :
            Unital<byte>,
            Unital<sbyte>,
            Unital<short>,
            Unital<ushort>,
            Unital<int>,
            Unital<uint>,
            Unital<long>,
            Unital<ulong>,
            Unital<float>,
            Unital<double>,
            Unital<decimal>,
            Unital<BigInteger>

        {
            static readonly Unital Inhabitant = default;

            [MethodImpl(Inline)]
            public static Unital<T> Operator<T>() 
                => cast<Unital<T>>(Inhabitant);

            byte Unital<byte>.one 
            {
                [MethodImpl(Inline)]
                get => 1;
            }

            sbyte Unital<sbyte>.one 
            {
                [MethodImpl(Inline)]
                get => 1;
            }

            short Unital<short>.one 
            {
                [MethodImpl(Inline)]
                get => 1;
            }

            ushort Unital<ushort>.one 
            {
                [MethodImpl(Inline)]
                get => 1;
            }

            int Unital<int>.one 
            {
                [MethodImpl(Inline)]
                get => 1;
            }

            uint Unital<uint>.one 
            {
                [MethodImpl(Inline)]
                get => 1;
            }

            long Unital<long>.one 
            {
                [MethodImpl(Inline)]
                get => 1;
            }

            ulong Unital<ulong>.one 
            {
                [MethodImpl(Inline)]
                get => 1;
            }

            float Unital<float>.one 
            {
                [MethodImpl(Inline)]
                get => 1;
            }

            double Unital<double>.one 
            {
                [MethodImpl(Inline)]
                get => 1;
            }

            decimal Unital<decimal>.one 
            {
                [MethodImpl(Inline)]
                get => 1;
            }

            BigInteger Unital<BigInteger>.one 
            {
                [MethodImpl(Inline)]
                get => BigInteger.One;
            }
        }

    }
}