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
        static byte mul(byte lhs, byte rhs)
            => (byte)(lhs * rhs);

        [MethodImpl(Inline)]
        static sbyte mul(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs * rhs);

        [MethodImpl(Inline)]
        static ushort mul(ushort lhs, ushort rhs)
            => (ushort)(lhs * rhs);

        [MethodImpl(Inline)]
        static short mul(short lhs, short rhs)
            => (short)(lhs * rhs);

        [MethodImpl(Inline)]
        static int mul(int lhs, int rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        static uint mul(uint lhs, uint rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        static ulong mul(ulong lhs, ulong rhs)
            => lhs * rhs;


        [MethodImpl(Inline)]
        static float mul(float lhs, float rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        static double mul(double lhs, double rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        static decimal mul(decimal lhs, decimal rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        static BigInteger mul(BigInteger lhs, BigInteger rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        static long mul(long lhs, long rhs)
            => lhs * rhs;

        static readonly PrimalIndex MulDelegates = PrimalKinds.index<object>
            (
                @sbyte : new PrimalBinOp<sbyte>(mul),
                @byte : new PrimalBinOp<byte>(mul),
                @short : new PrimalBinOp<short>(mul),
                @ushort : new PrimalBinOp<ushort>(mul),
                @int : new PrimalBinOp<int>(mul),
                @uint : new PrimalBinOp<uint>(mul),
                @long : new PrimalBinOp<long>(mul),
                @ulong : new PrimalBinOp<ulong>(mul),
                @float : new PrimalBinOp<float>(mul),
                @double : new PrimalBinOp<double>(mul),
                @decimal : new PrimalBinOp<decimal>(mul),
                bigint : new PrimalBinOp<BigInteger>(mul)
            );

        readonly struct Mul<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalBinOp<T> Op 
                = MulDelegates.lookup<T,PrimalBinOp<T>>();
        }

    }
}