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
        static bool eq(byte lhs, byte rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        static bool eq(sbyte lhs, sbyte rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        static bool eq(ushort lhs, ushort rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        static bool eq(short lhs, short rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        static bool eq(int lhs, int rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        static bool eq(uint lhs, uint rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        static bool eq(long lhs, long rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        static bool eq(ulong lhs, ulong rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        static bool eq(double lhs, double rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        static bool eq(float lhs, float rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        static bool eq(decimal lhs, decimal rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        static bool eq(BigInteger lhs, BigInteger rhs)
            => lhs == rhs;
        
        static readonly PrimalIndex EqDelegates = PrimKinds.index<object>
            (
                @sbyte : new PrimalBinPred<sbyte>(eq),
                @byte : new PrimalBinPred<byte>(eq),
                @short : new PrimalBinPred<short>(eq),
                @ushort : new PrimalBinPred<ushort>(eq),
                @int : new PrimalBinPred<int>(eq),
                @uint : new PrimalBinPred<uint>(eq),
                @long : new PrimalBinPred<long>(eq),
                @ulong : new PrimalBinPred<ulong>(eq),
                @float : new PrimalBinPred<float>(eq),
                @double : new PrimalBinPred<double>(eq),
                @decimal : new PrimalBinPred<decimal>(eq),
                bigint : new PrimalBinPred<BigInteger>(eq)
            );

        readonly struct Eq<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalBinPred<T> Op 
                = EqDelegates.lookup<T,PrimalBinPred<T>>();
        }


    }

}