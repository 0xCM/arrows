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
        static bool gt(byte lhs, byte rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        static bool gt(sbyte lhs, sbyte rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        static bool gt(ushort lhs, ushort rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        static bool gt(short lhs, short rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        static bool gt(int lhs, int rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        static bool gt(uint lhs, uint rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        static bool gt(long lhs, long rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        static bool gt(ulong lhs, ulong rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        static bool gt(double lhs, double rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        static bool gt(float lhs, float rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        static bool gt(decimal lhs, decimal rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        static bool gt(BigInteger lhs, BigInteger rhs)
            => lhs > rhs;
        
        static readonly PrimalIndex GtDelegates = PrimKinds.index<object>
            (
                @sbyte : new PrimalBinPred<sbyte>(gt),
                @byte : new PrimalBinPred<byte>(gt),
                @short : new PrimalBinPred<short>(gt),
                @ushort : new PrimalBinPred<ushort>(gt),
                @int : new PrimalBinPred<int>(gt),
                @uint : new PrimalBinPred<uint>(gt),
                @long : new PrimalBinPred<long>(gt),
                @ulong : new PrimalBinPred<ulong>(gt),
                @float : new PrimalBinPred<float>(gt),
                @double : new PrimalBinPred<double>(gt),
                @decimal : new PrimalBinPred<decimal>(gt),
                bigint : new PrimalBinPred<BigInteger>(gt)
            );

        readonly struct Gt<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalBinPred<T> Op 
                = GtDelegates.lookup<T,PrimalBinPred<T>>();
        }


    }

}