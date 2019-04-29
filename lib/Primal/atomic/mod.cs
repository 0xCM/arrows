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
        static byte mod(byte lhs, byte rhs)
            => (byte)(lhs % rhs);

        [MethodImpl(Inline)]
        static sbyte mod(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs % rhs);

        [MethodImpl(Inline)]
        static ushort mod(ushort lhs, ushort rhs)
            => (ushort)(lhs % rhs);

        [MethodImpl(Inline)]
        static short mod(short lhs, short rhs)
            => (short)(lhs % rhs);

        [MethodImpl(Inline)]
        static int mod(int lhs, int rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        static uint mod(uint lhs, uint rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        static ulong mod(ulong lhs, ulong rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        static decimal mod(decimal lhs, decimal rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        static double mod(double lhs, double rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        static float mod(float lhs, float rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        static BigInteger mod(BigInteger lhs, BigInteger rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        static long mod(long lhs, long rhs)
            => lhs % rhs;

        static readonly PrimalIndex ModDelegates = PrimalKinds.index<object>
            (
                @sbyte : new PrimalBinOp<sbyte>(mod),
                @byte : new PrimalBinOp<byte>(mod),
                @short : new PrimalBinOp<short>(mod),
                @ushort : new PrimalBinOp<ushort>(mod),
                @int : new PrimalBinOp<int>(mod),
                @uint : new PrimalBinOp<uint>(mod),
                @long : new PrimalBinOp<long>(mod),
                @ulong : new PrimalBinOp<ulong>(mod),
                @float : new PrimalBinOp<float>(mod),
                @double : new PrimalBinOp<double>(mod),
                @decimal : new PrimalBinOp<decimal>(mod),
                bigint : new PrimalBinOp<BigInteger>(mod)
            );

        readonly struct Mod<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalBinOp<T> Op 
                = ModDelegates.lookup<T,PrimalBinOp<T>>();
        }



    }
}