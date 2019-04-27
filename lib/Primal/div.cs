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
        static byte div(byte lhs, byte rhs)
            => (byte)(lhs / rhs);

        [MethodImpl(Inline)]
        static sbyte div(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs / rhs);

        [MethodImpl(Inline)]
        static ushort div(ushort lhs, ushort rhs)
            => (ushort)(lhs / rhs);

        [MethodImpl(Inline)]
        static short div(short lhs, short rhs)
            => (short)(lhs / rhs);

        [MethodImpl(Inline)]
        static int div(int lhs, int rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        static uint div(uint lhs, uint rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        static ulong div(ulong lhs, ulong rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        static decimal div(decimal lhs, decimal rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        static double div(double lhs, double rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        static float div(float lhs, float rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        static BigInteger div(BigInteger lhs, BigInteger rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        static long div(long lhs, long rhs)
            => lhs / rhs;

        static readonly PrimalIndex DivDelegates = PrimKinds.index<object>
            (
                @sbyte : new PrimalBinOp<sbyte>(div),
                @byte : new PrimalBinOp<byte>(div),
                @short : new PrimalBinOp<short>(div),
                @ushort : new PrimalBinOp<ushort>(div),
                @int : new PrimalBinOp<int>(div),
                @uint : new PrimalBinOp<uint>(div),
                @long : new PrimalBinOp<long>(div),
                @ulong : new PrimalBinOp<ulong>(div),
                @float : new PrimalBinOp<float>(div),
                @double : new PrimalBinOp<double>(div),
                @decimal : new PrimalBinOp<decimal>(div),
                bigint : new PrimalBinOp<BigInteger>(div)
            );

        readonly struct Div<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalBinOp<T> Op 
                = DivDelegates.lookup<T,PrimalBinOp<T>>();
        }

 


    }
}