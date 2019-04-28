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
        static byte add(byte lhs, byte rhs)
            => (byte)(lhs + rhs);

        [MethodImpl(Inline)]
        static sbyte add(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs + rhs);

        [MethodImpl(Inline)]
        static ushort add(ushort lhs, ushort rhs)
            => (ushort)(lhs + rhs);

        [MethodImpl(Inline)]
        static short add(short lhs, short rhs)
            => (short)(lhs + rhs);

        [MethodImpl(Inline)]
        static int add(int lhs, int rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        static uint add(uint lhs, uint rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        static ulong add(ulong lhs, ulong rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        static long add(long lhs, long rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        static float add(float lhs, float rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        static double add(double lhs, double rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        static decimal add(decimal lhs, decimal rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        static BigInteger add(BigInteger lhs, BigInteger rhs)
            => lhs + rhs;


        static readonly PrimalIndex AddDelegates = PrimalIndex.define
            (
                @sbyte : new PrimalBinOp<sbyte>(add),
                @byte : new PrimalBinOp<byte>(add),
                @short : new PrimalBinOp<short>(add),
                @ushort : new PrimalBinOp<ushort>(add),
                @int : new PrimalBinOp<int>(add),
                @uint : new PrimalBinOp<uint>(add),
                @long : new PrimalBinOp<long>(add),
                @ulong : new PrimalBinOp<ulong>(add),
                @float : new PrimalBinOp<float>(add),
                @double : new PrimalBinOp<double>(add),
                @decimal : new PrimalBinOp<decimal>(add),
                bigint : new PrimalBinOp<BigInteger>(add)
            );

        readonly struct Add<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalBinOp<T> Op 
                = AddDelegates.lookup<T,PrimalBinOp<T>>();
        }

    }

}