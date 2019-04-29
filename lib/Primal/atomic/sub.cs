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
        static byte sub(byte lhs, byte rhs)
            => (byte)(lhs - rhs);

        [MethodImpl(Inline)]
        static sbyte sub(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs - rhs);

        [MethodImpl(Inline)]
        static ushort sub(ushort lhs, ushort rhs)
            => (ushort)(lhs - rhs);

        [MethodImpl(Inline)]
        static short sub(short lhs, short rhs)
            => (short)(lhs - rhs);

        [MethodImpl(Inline)]
        static int sub(int lhs, int rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        static uint sub(uint lhs, uint rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        static ulong sub(ulong lhs, ulong rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        static long sub(long lhs, long rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        static float sub(float lhs, float rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        static double sub(double lhs, double rhs)
            => lhs - rhs;


        [MethodImpl(Inline)]
        static decimal sub(decimal lhs, decimal rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        static BigInteger sub(BigInteger lhs, BigInteger rhs)
            => lhs - rhs;


       static readonly PrimalIndex SubDelegates = PrimalKinds.index<object>
            (
                @sbyte : new PrimalBinOp<sbyte>(sub),
                @byte : new PrimalBinOp<byte>(sub),
                @short : new PrimalBinOp<short>(sub),
                @ushort : new PrimalBinOp<ushort>(sub),
                @int : new PrimalBinOp<int>(sub),
                @uint : new PrimalBinOp<uint>(sub),
                @long : new PrimalBinOp<long>(sub),
                @ulong : new PrimalBinOp<ulong>(sub),
                @float : new PrimalBinOp<float>(sub),
                @double : new PrimalBinOp<double>(sub),
                @decimal : new PrimalBinOp<decimal>(sub),
                bigint : new PrimalBinOp<BigInteger>(sub)
            );

        readonly struct Sub<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalBinOp<T> Op 
                = SubDelegates.lookup<T,PrimalBinOp<T>>();
        }

    }
}