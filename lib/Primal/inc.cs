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
        static byte inc(byte x)
            => ++x;

        [MethodImpl(Inline)]
        static sbyte inc(sbyte x)
            => ++x;

        [MethodImpl(Inline)]
        static short inc(short x)
            => ++x;

        [MethodImpl(Inline)]
        static ushort inc(ushort x)
            => ++x;

        [MethodImpl(Inline)]
        static int inc(int x)
            => ++x;

        [MethodImpl(Inline)]
        static uint inc(uint x)
            => ++x;

        [MethodImpl(Inline)]
        static long inc(long x)
            => ++x;

        [MethodImpl(Inline)]
        static ulong inc(ulong x)
            => ++x;

        [MethodImpl(Inline)]
        static double inc(double x)
            => ++x;

        [MethodImpl(Inline)]
        static float inc(float x)
            => ++x;

        [MethodImpl(Inline)]
        static decimal inc(decimal x)
            => ++x;

        [MethodImpl(Inline)]
        static BigInteger inc(BigInteger x)
            => ++x;

        static readonly PrimalIndex IncDelegates = PrimKinds.index<object>
            (
                @sbyte : new PrimalUnaryOp<sbyte>(inc),
                @byte : new PrimalUnaryOp<byte>(inc),
                @short : new PrimalUnaryOp<short>(inc),
                @ushort : new PrimalUnaryOp<ushort>(inc),
                @int : new PrimalUnaryOp<int>(inc),
                @uint : new PrimalUnaryOp<uint>(inc),
                @long : new PrimalUnaryOp<long>(inc),
                @ulong : new PrimalUnaryOp<ulong>(inc),
                @float : new PrimalUnaryOp<float>(inc),
                @double : new PrimalUnaryOp<double>(inc),
                @decimal : new PrimalUnaryOp<decimal>(inc),
                bigint : new PrimalUnaryOp<BigInteger>(inc)
            );

        readonly struct Inc<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalUnaryOp<T> Op 
                = IncDelegates.lookup<T,PrimalUnaryOp<T>>();
        }




    }

}