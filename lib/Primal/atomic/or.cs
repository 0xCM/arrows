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
        static byte or(byte lhs, byte rhs)
            => (byte)(lhs | rhs);

        [MethodImpl(Inline)]
        static sbyte or(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs | rhs);

        [MethodImpl(Inline)]
        static ushort or(ushort lhs, ushort rhs)
            => (ushort)(lhs | rhs);

        [MethodImpl(Inline)]
        static short or(short lhs, short rhs)
            => (short)(lhs | rhs);

        [MethodImpl(Inline)]
        static int or(int lhs, int rhs)
            => lhs | rhs;

        [MethodImpl(Inline)]
        static uint or(uint lhs, uint rhs)
            => lhs | rhs;

        [MethodImpl(Inline)]
        static ulong or(ulong lhs, ulong rhs)
            => lhs | rhs;


        [MethodImpl(Inline)]
        static double or(double lhs, double rhs)
            => BitConverter.Int64BitsToDouble(BitConverter.DoubleToInt64Bits(lhs) & BitConverter.DoubleToInt64Bits(rhs));

        [MethodImpl(Inline)]
        static float or(float lhs, float rhs)
            => BitConverter.Int32BitsToSingle(BitConverter.SingleToInt32Bits(lhs) & BitConverter.SingleToInt32Bits(rhs));

        [MethodImpl(Inline)]
        static BigInteger or(BigInteger lhs, BigInteger rhs)
            => lhs | rhs;

        [MethodImpl(Inline)]
        static long or(long lhs, long rhs)
            => lhs | rhs;

        static readonly PrimalIndex OrDelegates = PrimKinds.index<object>
            (
                @sbyte : new PrimalBinOp<sbyte>(or),
                @byte : new PrimalBinOp<byte>(or),
                @short : new PrimalBinOp<short>(or),
                @ushort : new PrimalBinOp<ushort>(or),
                @int : new PrimalBinOp<int>(or),
                @uint : new PrimalBinOp<uint>(or),
                @long : new PrimalBinOp<long>(or),
                @ulong : new PrimalBinOp<ulong>(or),
                @float : new PrimalBinOp<float>(or),
                @double : new PrimalBinOp<double>(or),
                bigint : new PrimalBinOp<BigInteger>(or)
            );

        readonly struct Or<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalBinOp<T> Op 
                = OrDelegates.lookup<T,PrimalBinOp<T>>();
        }



    }

}