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
        static Index<byte> and(Index<byte> lhs, Index<byte> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (byte)(lhs[i] & rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<sbyte> and(Index<sbyte> lhs, Index<sbyte> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (sbyte)(lhs[i] & rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<short> and(Index<short> lhs, Index<short> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (short)(lhs[i] & rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<ushort> and(Index<ushort> lhs, Index<ushort> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (ushort)(lhs[i] & rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<int> and(Index<int> lhs, Index<int> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] & rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<uint> and(Index<uint> lhs, Index<uint> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] & rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<long> and(Index<long> lhs, Index<long> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] & rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<ulong> and(Index<ulong> lhs, Index<ulong> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] & rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<BigInteger> and(Index<BigInteger> lhs, Index<BigInteger> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] & rhs[i];
            return dst;
        }

        static readonly PrimalIndex AndDelegates = PrimalKinds.index<object>
            (
                @sbyte : new PrimalFusedBinOp<sbyte>(and),
                @byte : new PrimalFusedBinOp<byte>(and),
                @short : new PrimalFusedBinOp<short>(and),
                @ushort : new PrimalFusedBinOp<ushort>(and),
                @int : new PrimalFusedBinOp<int>(and),
                @uint : new PrimalFusedBinOp<uint>(and),
                @long : new PrimalFusedBinOp<long>(and),
                @ulong : new PrimalFusedBinOp<ulong>(and),
                bigint : new PrimalFusedBinOp<BigInteger>(and)
            );

        readonly struct And<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalFusedBinOp<T> Op 
                = AndDelegates.lookup<T,PrimalFusedBinOp<T>>();
        }
    }
}