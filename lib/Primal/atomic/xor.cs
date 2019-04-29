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
        static byte xor(byte lhs, byte rhs)
            => (byte)(lhs ^ rhs);

        [MethodImpl(Inline)]
        static sbyte xor(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs ^ rhs);

        [MethodImpl(Inline)]
        static ushort xor(ushort lhs, ushort rhs)
            => (ushort)(lhs ^ rhs);

        [MethodImpl(Inline)]
        static short xor(short lhs, short rhs)
            => (short)(lhs ^ rhs);

        [MethodImpl(Inline)]
        static int xor(int lhs, int rhs)
            => lhs ^ rhs;

        [MethodImpl(Inline)]
        static uint xor(uint lhs, uint rhs)
            => lhs ^ rhs;

        [MethodImpl(Inline)]
        static ulong xor(ulong lhs, ulong rhs)
            => lhs ^ rhs;


        [MethodImpl(Inline)]
        static double xor(double lhs, double rhs)
            => BitConverter.Int64BitsToDouble(BitConverter.DoubleToInt64Bits(lhs) & BitConverter.DoubleToInt64Bits(rhs));

        [MethodImpl(Inline)]
        static float xor(float lhs, float rhs)
            => BitConverter.Int32BitsToSingle(BitConverter.SingleToInt32Bits(lhs) & BitConverter.SingleToInt32Bits(rhs));

        [MethodImpl(Inline)]
        static BigInteger xor(BigInteger lhs, BigInteger rhs)
            => lhs ^ rhs;

        [MethodImpl(Inline)]
        static long xor(long lhs, long rhs)
            => lhs ^ rhs;

        static readonly PrimalIndex XOrDelegates = PrimalKinds.index<object>
            (
                @sbyte : new PrimalBinOp<sbyte>(xor),
                @byte : new PrimalBinOp<byte>(xor),
                @short : new PrimalBinOp<short>(xor),
                @ushort : new PrimalBinOp<ushort>(xor),
                @int : new PrimalBinOp<int>(xor),
                @uint : new PrimalBinOp<uint>(xor),
                @long : new PrimalBinOp<long>(xor),
                @ulong : new PrimalBinOp<ulong>(xor),
                @float : new PrimalBinOp<float>(xor),
                @double : new PrimalBinOp<double>(xor),
                bigint : new PrimalBinOp<BigInteger>(xor)
            );

        readonly struct XOr<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalBinOp<T> Op 
                = XOrDelegates.lookup<T,PrimalBinOp<T>>();
        }



    }

}