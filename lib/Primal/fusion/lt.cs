//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    using static zcore;

    partial class PrimalFusion
    {

        [MethodImpl(Inline)]
        static Index<bool> lt(Index<byte> lhs, Index<byte> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] < rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<bool> lt(Index<sbyte> lhs, Index<sbyte> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] < rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<bool> lt(Index<short> lhs, Index<short> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] < rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<bool> lt(Index<ushort> lhs, Index<ushort> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] < rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<bool> lt(Index<int> lhs, Index<int> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] < rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<bool> lt(Index<uint> lhs, Index<uint> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] < rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<bool> lt(Index<long> lhs, Index<long> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] < rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<bool> lt(Index<ulong> lhs, Index<ulong> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] < rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<bool> lt(Index<float> lhs, Index<float> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] < rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<bool> lt(Index<double> lhs, Index<double> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] < rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<bool> lt(Index<decimal> lhs, Index<decimal> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] < rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<bool> lt(Index<BigInteger> lhs, Index<BigInteger> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] < rhs[i];
            return dst;
        }

        static readonly PrimalIndex LtDelegates = PrimKinds.index<object>
            (
                @sbyte : new PrimalFusedPred<sbyte>(lt),
                @byte : new PrimalFusedPred<byte>(lt),
                @short : new PrimalFusedPred<short>(lt),
                @ushort : new PrimalFusedPred<ushort>(lt),
                @int : new PrimalFusedPred<int>(lt),
                @uint : new PrimalFusedPred<uint>(lt),
                @long : new PrimalFusedPred<long>(lt),
                @ulong : new PrimalFusedPred<ulong>(lt),
                @float : new PrimalFusedPred<float>(lt),
                @double : new PrimalFusedPred<double>(lt),
                @decimal : new PrimalFusedPred<decimal>(lt),
                bigint : new PrimalFusedPred<BigInteger>(lt)
            );

        readonly struct Lt<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalFusedPred<T> Op 
                = LtDelegates.lookup<T,PrimalFusedPred<T>>();
        }
    }
}