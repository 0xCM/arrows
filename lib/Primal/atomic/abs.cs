//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;

    partial class PrimalOps
    {
        [MethodImpl(Inline)]
        static sbyte abs(sbyte x)
            => Math.Abs(x);

        [MethodImpl(Inline)]
        static byte abs(byte x)
            => x;

        [MethodImpl(Inline)]
        static short abs(short x)
            => Math.Abs(x);

        [MethodImpl(Inline)]
        static ushort abs(ushort x)
            => x;

        [MethodImpl(Inline)]
        static int abs(int x)
            => Math.Abs(x);

        [MethodImpl(Inline)]
        static uint abs(uint x)
            => x;

        [MethodImpl(Inline)]
        static long abs(long x)
            => Math.Abs(x);

        [MethodImpl(Inline)]
        static ulong abs(ulong x)
            => x;

        [MethodImpl(Inline)]
        static float abs(float x)
            => MathF.Abs(x);

        [MethodImpl(Inline)]
        static double abs(double x)
            => Math.Abs(x);

        [MethodImpl(Inline)]
        static decimal abs(decimal x)
            => Math.Abs(x);

        [MethodImpl(Inline)]
        static BigInteger abs(BigInteger x)
            => BigInteger.Abs(x);

        static readonly PrimalIndex AbsDelegates = PrimalKinds.index<object>
            (
                @sbyte : new PrimalUnaryOp<sbyte>(abs),
                @byte : new PrimalUnaryOp<byte>(abs),
                @short : new PrimalUnaryOp<short>(abs),
                @ushort : new PrimalUnaryOp<ushort>(abs),
                @int : new PrimalUnaryOp<int>(abs),
                @uint : new PrimalUnaryOp<uint>(abs),
                @long : new PrimalUnaryOp<long>(abs),
                @ulong : new PrimalUnaryOp<ulong>(abs),
                @float : new PrimalUnaryOp<float>(abs),
                @double : new PrimalUnaryOp<double>(abs),
                @decimal : new PrimalUnaryOp<decimal>(abs),
                bigint : new PrimalUnaryOp<BigInteger>(abs)
            );

        readonly struct Abs<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalUnaryOp<T> Op 
                = AbsDelegates.lookup<T,PrimalUnaryOp<T>>();
        }
    }
}