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
        static Index<bool> gt(Index<byte> lhs, Index<byte> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] > rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<bool> gt(Index<sbyte> lhs, Index<sbyte> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] > rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<bool> gt(Index<short> lhs, Index<short> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] > rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<bool> gt(Index<ushort> lhs, Index<ushort> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] > rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<bool> gt(Index<int> lhs, Index<int> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] > rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<bool> gt(Index<uint> lhs, Index<uint> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] > rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<bool> gt(Index<long> lhs, Index<long> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] > rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<bool> gt(Index<ulong> lhs, Index<ulong> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] > rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<bool> gt(Index<float> lhs, Index<float> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] > rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<bool> gt(Index<double> lhs, Index<double> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] > rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<bool> gt(Index<decimal> lhs, Index<decimal> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] > rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<bool> gt(Index<BigInteger> lhs, Index<BigInteger> rhs)
        {
            var dst = alloc<bool>(matchedCount(lhs,rhs));
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] > rhs[i];
            return dst;
        }

        static readonly PrimalIndex GtDelegates = PrimKinds.index<object>
            (
                @sbyte : new PrimalFusedPred<sbyte>(gt),
                @byte : new PrimalFusedPred<byte>(gt),
                @short : new PrimalFusedPred<short>(gt),
                @ushort : new PrimalFusedPred<ushort>(gt),
                @int : new PrimalFusedPred<int>(gt),
                @uint : new PrimalFusedPred<uint>(gt),
                @long : new PrimalFusedPred<long>(gt),
                @ulong : new PrimalFusedPred<ulong>(gt),
                @float : new PrimalFusedPred<float>(gt),
                @double : new PrimalFusedPred<double>(gt),
                @decimal : new PrimalFusedPred<decimal>(gt),
                bigint : new PrimalFusedPred<BigInteger>(gt)
            );

        readonly struct Gt<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalFusedPred<T> Op 
                = GtDelegates.lookup<T,PrimalFusedPred<T>>();
        }
    }
}