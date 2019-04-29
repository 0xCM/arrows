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
        static byte and(byte lhs, byte rhs)
            => (byte)(lhs & rhs);

        [MethodImpl(Inline)]
        static sbyte and(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs & rhs);

        [MethodImpl(Inline)]
        static ushort and(ushort lhs, ushort rhs)
            => (ushort)(lhs & rhs);

        [MethodImpl(Inline)]
        static short and(short lhs, short rhs)
            => (short)(lhs & rhs);

        [MethodImpl(Inline)]
        static int and(int lhs, int rhs)
            => lhs & rhs;

        [MethodImpl(Inline)]
        static uint and(uint lhs, uint rhs)
            => lhs & rhs;

        [MethodImpl(Inline)]
        static ulong and(ulong lhs, ulong rhs)
            => lhs & rhs;

        [MethodImpl(Inline)]
        static double and(double lhs, double rhs)
            => BitConverter.Int64BitsToDouble(BitConverter.DoubleToInt64Bits(lhs) & BitConverter.DoubleToInt64Bits(rhs));

        [MethodImpl(Inline)]
        static float and(float lhs, float rhs)
            => BitConverter.Int32BitsToSingle(BitConverter.SingleToInt32Bits(lhs) & BitConverter.SingleToInt32Bits(rhs));

        [MethodImpl(Inline)]
        static BigInteger and(BigInteger lhs, BigInteger rhs)
            => lhs & rhs;

        [MethodImpl(Inline)]
        static long and(long lhs, long rhs)
            => lhs & rhs;

        static readonly PrimalIndex AndDelegates = PrimalKinds.index<object>
            (
                @sbyte : new PrimalBinOp<sbyte>(and),
                @byte : new PrimalBinOp<byte>(and),
                @short : new PrimalBinOp<short>(and),
                @ushort : new PrimalBinOp<ushort>(and),
                @int : new PrimalBinOp<int>(and),
                @uint : new PrimalBinOp<uint>(and),
                @long : new PrimalBinOp<long>(and),
                @ulong : new PrimalBinOp<ulong>(and),
                @float : new PrimalBinOp<float>(and),
                @double : new PrimalBinOp<double>(and),
                bigint : new PrimalBinOp<BigInteger>(and)
            );

        readonly struct And<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalBinOp<T> Op 
                = AndDelegates.lookup<T,PrimalBinOp<T>>();
        }


    }


}